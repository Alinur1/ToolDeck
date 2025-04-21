using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolDeck
{
    public partial class MergePDF : UserControl
    {
        private List<PdfItem> _pdfItems = new List<PdfItem>();
        private Control _draggedPanel = null;

        public MergePDF()
        {
            InitializeComponent();
        }

        private Image GetPdfThumbnail(string filePath, int width = 190, int height = 240)
        {
            using (var pdfDoc = PdfiumViewer.PdfDocument.Load(filePath))
            {
                // Render first page as image
                var img = pdfDoc.Render(0, width, height, true);
                return img;
            }
        }

        private void RenderPdfPreview()
        {
            panelPdfPreview.Controls.Clear();

            foreach (var item in _pdfItems)
            {
                var panel = new Panel
                {
                    Width = 240,
                    Height = 300,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Tag = item
                };

                var picBox = new PictureBox
                {
                    Image = GetPdfThumbnail(item.FilePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 190
                };

                var lbl = new Label
                {
                    Text = item.FileName,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoEllipsis = true
                };

                // Add context menu
                var contextMenu = new ContextMenuStrip();
                var removeItem = new ToolStripMenuItem("Remove");
                removeItem.Click += (s, e) =>
                {
                    // On remove clicked
                    panelPdfPreview.Controls.Remove(panel);
                    _pdfItems.Remove(item);

                    if (picBox.Image != null)
                    {
                        picBox.Image.Dispose();
                        picBox.Image = null;
                    }

                    panel.Dispose();
                };

                contextMenu.Items.Add(removeItem);
                panel.ContextMenuStrip = contextMenu;

                // Add controls and events
                panel.Controls.Add(picBox);
                panel.Controls.Add(lbl);
                panel.MouseDown += Panel_MouseDown;
                panel.AllowDrop = true;
                panel.DragEnter += Panel_DragEnter;
                panel.DragDrop += Panel_DragDrop;

                panelPdfPreview.Controls.Add(panel);
            }
        }

        private void MergePdfFiles(List<string> inputFiles, string outputPath)
        {
            try
            {
                using var writer = new PdfWriter(outputPath);
                using var mergedPdf = new iText.Kernel.Pdf.PdfDocument(writer);
                var merger = new PdfMerger(mergedPdf);

                foreach (var file in inputFiles)
                {
                    try
                    {
                        var reader = new PdfReader(file);
                        var pdf = new iText.Kernel.Pdf.PdfDocument(reader);
                        merger.Merge(pdf, 1, pdf.GetNumberOfPages());
                        pdf.Close();
                    }
                    catch (Exception innerEx)
                    {
                        MessageBox.Show($"Error merging file:\n{file}\n\n{innerEx.Message}", "File Merge Error");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in MergePdfFiles: " + ex.Message);
            }
        }

        private void SelectFiles()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "PDF Files (*.pdf)|*.pdf";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in ofd.FileNames)
                    {
                        if (!_pdfItems.Any(p => p.FilePath == file))
                        {
                            _pdfItems.Add(new PdfItem { FilePath = file });
                        }
                    }

                    RenderPdfPreview();
                }
            }
        }

        private void SaveMergedFiles()
        {
            if (_pdfItems.Count < 2)
            {
                MessageBox.Show("Please add at least two PDF files to merge.", "Warning");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.Title = "Save Merged PDF";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MergePdfFiles(_pdfItems.Select(p => p.FilePath).ToList(), sfd.FileName);
                        MessageBox.Show("Merged PDF saved successfully!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while merging PDF: " + ex.Message);
                    }
                }
            }
        }

        private void ClearAll()
        {
            foreach (Control control in panelPdfPreview.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control inner in panel.Controls)
                    {
                        if (inner is PictureBox picBox && picBox.Image != null)
                        {
                            picBox.Image.Dispose();
                            picBox.Image = null;
                        }
                    }
                }
            }

            panelPdfPreview.Controls.Clear();
            _pdfItems.Clear();
            GC.Collect(); // Optional: Force garbage collection
        }





        //UI Related codes

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            SelectFiles();
        }

        private void btnSaveMerged_Click(object sender, EventArgs e)
        {
            SaveMergedFiles();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void pnlPdfPreview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Any(f => Path.GetExtension(f).ToLower() == ".pdf"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void pnlPdfPreview_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (Path.GetExtension(file).ToLower() == ".pdf" && !_pdfItems.Any(p => p.FilePath == file))
                {
                    _pdfItems.Add(new PdfItem { FilePath = file });
                }
            }

            RenderPdfPreview();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            _draggedPanel = sender as Control;
            if (_draggedPanel != null)
                _draggedPanel.DoDragDrop(_draggedPanel, DragDropEffects.Move);
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            var targetPanel = sender as Control;
            if (_draggedPanel == null || targetPanel == null || _draggedPanel == targetPanel)
                return;

            int fromIndex = panelPdfPreview.Controls.GetChildIndex(_draggedPanel);
            int toIndex = panelPdfPreview.Controls.GetChildIndex(targetPanel);

            panelPdfPreview.Controls.SetChildIndex(_draggedPanel, toIndex);

            //Sync _pdfItems list order
            var movedItem = _draggedPanel.Tag as PdfItem;
            if (movedItem != null)
            {
                _pdfItems.RemoveAt(fromIndex);
                _pdfItems.Insert(toIndex, movedItem);
            }

            _draggedPanel = null;
        }
    }



    public class PdfItem
    {
        public string FilePath { get; set; }
        public string FileName => Path.GetFileName(FilePath);
    }

}

using iText.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ToolDeck.Logger;

namespace ToolDeck
{
    public partial class ReorderPagesUI : UserControl
    {
        private string _selectedPdfPath = string.Empty;
        private List<PdfItem> _pdfItems = new List<PdfItem>();
        private Control _draggedPanel = null;
        private int _draggedPanelIndex;

        public ReorderPagesUI()
        {
            InitializeComponent();

            panelPdfPreview.MouseDown += panelPdfPreview_MouseDown;
            panelPdfPreview.AllowDrop = true;
            panelPdfPreview.DragEnter += panelPdfPreview_DragEnter;
            panelPdfPreview.DragDrop += panelPdfPreview_DragDrop;
        }

        private async void SelectPDF()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PDF Files (*.pdf)|*.pdf";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        _selectedPdfPath = ofd.FileName;

                        // Add the selected file to _pdfItems if not already present
                        if (!_pdfItems.Any(p => p.FilePath == _selectedPdfPath))
                        {
                            _pdfItems.Add(new PdfItem { FilePath = _selectedPdfPath });
                        }
                    }
                }
                await RenderPdfPagePreviewsAsync(_selectedPdfPath);
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ReorderPagesUI in SelectPDF: ", ex);
            }
        }

        private void ClearAll()
        {
            try
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
                        panel.Dispose();
                    }
                }

                panelPdfPreview.Controls.Clear();
                _pdfItems.Clear();
                GC.Collect(); // Optional: Force garbage collection
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ReorderPagesUI in ClearAll: ", ex);
            }
        }

        private void SavePDF()
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedPdfPath)) return;

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = $"{DateTime.Now} - Reordered.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (PdfReader reader = new PdfReader(_selectedPdfPath))
                        using (PdfWriter writer = new PdfWriter(sfd.FileName))
                        using (PdfDocument srcDoc = new PdfDocument(reader))
                        using (PdfDocument destDoc = new PdfDocument(writer))
                        {
                            foreach (Control control in panelPdfPreview.Controls)
                            {
                                Label lbl = control.Controls.OfType<Label>().FirstOrDefault();
                                if (lbl != null && lbl.Text.StartsWith("Page"))
                                {
                                    int pageNum = int.Parse(lbl.Text.Replace("Page", "").Trim());
                                    srcDoc.CopyPagesTo(pageNum, pageNum, destDoc);
                                }
                            }
                        }

                        MessageBox.Show("PDF saved in the new order!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                LogError("An error occurred at ReorderPagesUI in SavePDF: ", ex);
            }
        }

        private async Task RenderPdfPagePreviewsAsync(string filePath)
        {
            panelPdfPreview.Controls.Clear();

            await Task.Run(() =>
            {
                try
                {
                    foreach (var item in _pdfItems)
                    {
                        using (var pdfDoc = PdfiumViewer.PdfDocument.Load(item.FilePath))
                        {
                            for (int i = 0; i < pdfDoc.PageCount; i++)
                            {
                                var image = pdfDoc.Render(i, 150, 250, true);
                                int pageNum = i + 1;

                                Invoke(new Action(() =>
                                {
                                    var panel = new Panel
                                    {
                                        Width = 170,
                                        Height = 300,
                                        BorderStyle = BorderStyle.FixedSingle,
                                        BackColor = Color.FromArgb(46, 46, 62),
                                        Margin = new Padding(10),
                                        Padding = new Padding(5)
                                    };

                                    var pb = new PictureBox
                                    {
                                        Image = image,
                                        SizeMode = PictureBoxSizeMode.Zoom,
                                        Dock = DockStyle.Top,
                                        Height = 190,
                                        BackColor = Color.FromArgb(30, 30, 45)
                                    };

                                    var lbl = new Label
                                    {
                                        Text = $"Page {pageNum}",
                                        TextAlign = ContentAlignment.MiddleCenter,
                                        Dock = DockStyle.Bottom,
                                        Height = 30,
                                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                                        ForeColor = Color.White,
                                        BackColor = Color.FromArgb(30, 30, 45)
                                    };

                                    // Events for dragging
                                    panel.MouseDown += PagePanel_MouseDown;
                                    panel.MouseMove += PagePanel_MouseMove;

                                    panel.Controls.Add(pb);
                                    panel.Controls.Add(lbl);
                                    panelPdfPreview.Controls.Add(panel);
                                }));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogError("An error occurred at ReorderPagesUI in RenderPdfPagePreviewsAsync: ", ex);
                }
            });
        }






        // UI Event Handlers

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            SelectPDF();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePDF();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void PagePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _draggedPanel = sender as Panel;
            _draggedPanelIndex = panelPdfPreview.Controls.GetChildIndex(_draggedPanel);
        }

        private void PagePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draggedPanel != null && e.Button == MouseButtons.Left)
            {
                _draggedPanel.DoDragDrop(_draggedPanel, DragDropEffects.Move);
            }
        }

        private void panelPdfPreview_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                _draggedPanel = sender as Control;
                if (_draggedPanel != null)
                    _draggedPanel.DoDragDrop(_draggedPanel, DragDropEffects.Move);
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ReorderPagesUI in panelPdfPreview_MouseDown: ", ex);
            }
        }

        private void panelPdfPreview_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(typeof(Panel)))
                {
                    e.Effect = DragDropEffects.Move;
                }
                else if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (files.Any(f => Path.GetExtension(f).ToLower() == ".pdf"))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ReorderPagesUI in panelPdfPreview_DragEnter: ", ex);
            }
        }

        private async void panelPdfPreview_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(typeof(Panel)))
                {
                    Panel droppedPanel = (Panel)e.Data.GetData(typeof(Panel));
                    Point clientPoint = panelPdfPreview.PointToClient(new Point(e.X, e.Y));
                    Control target = panelPdfPreview.GetChildAtPoint(clientPoint);

                    if (target != null && target != droppedPanel)
                    {
                        int targetIndex = panelPdfPreview.Controls.GetChildIndex(target);
                        panelPdfPreview.Controls.SetChildIndex(droppedPanel, targetIndex);
                        panelPdfPreview.Invalidate();
                    }

                    _draggedPanel = null;
                    return;
                }
            }
            catch(Exception ex)
            {
                LogError("An error occurred at ReorderPagesUI in panelPdfPreview_DragDrop#1: ", ex);
            }

            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower() == ".pdf" && !_pdfItems.Any(p => p.FilePath == file))
                    {
                        _selectedPdfPath = file;
                        _pdfItems.Add(new PdfItem { FilePath = file });
                        await RenderPdfPagePreviewsAsync(_selectedPdfPath);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ReorderPagesUI in panelPdfPreview_DragDrop#2: ", ex);
            }
        }
    }
}

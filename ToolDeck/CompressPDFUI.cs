using iText.Kernel.Pdf;
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
    public partial class CompressPDFUI : UserControl
    {
        private string _selectedPdfPath = string.Empty;
        public CompressPDFUI()
        {
            InitializeComponent();
            SetupDragAndDrop();
        }

        private async void SelectFiles()
        {
            try
            {
                using OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedPdfPath = ofd.FileName;
                    await RenderPreviewAsync(_selectedPdfPath);
                }
            }
            catch (Exception ex)
            {
                LogError("An error occurred at CompressPDFUI in SelectFiles: ", ex);
            }
        }

        private void ClearPanel()
        {
            try
            {
                foreach (Control ctrl in panelPreview.Controls)
                {
                    if (ctrl is PictureBox pb && pb.Image != null)
                    {
                        pb.Image.Dispose();
                        pb.Image = null;
                    }
                }

                panelPreview.Controls.Clear();
                _selectedPdfPath = string.Empty;
            }
            catch (Exception ex)
            {
                LogError("An error occurred at CompressPDFUI in ClearPanel: ", ex);
            }
        }

        private void SetupDragAndDrop()
        {
            try
            {
                panelPreview.AllowDrop = true;
                panelPreview.DragEnter += (s, e) =>
                {
                    if (e.Data.GetDataPresent(DataFormats.FileDrop))
                        e.Effect = DragDropEffects.Copy;
                };

                panelPreview.DragDrop += async (s, e) =>
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (files != null && files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".pdf")
                    {
                        _selectedPdfPath = files[0];
                        await RenderPreviewAsync(_selectedPdfPath);
                    }
                };
            }
            catch(Exception ex)
            {
                LogError("An error occurred at CompressPDFUI in SetupDragAndDrop: ", ex);
            }
        }

        private async Task CompressPdfAsync(string inputPath, string outputPath)
        {
            try
            {
                await Task.Run(() =>
                {
                    var writerProps = new WriterProperties()
                        .SetCompressionLevel(CompressionConstants.BEST_COMPRESSION)
                        .AddXmpMetadata()
                        .SetFullCompressionMode(true);

                    using var reader = new PdfReader(inputPath);
                    using var writer = new PdfWriter(outputPath, writerProps);
                    using var pdfDoc = new PdfDocument(reader, writer);

                    pdfDoc.GetDocumentInfo().SetMoreInfo("CompressedBy", "ToolDeck");
                    pdfDoc.Close();
                });
            }
            catch(Exception ex)
            {
                LogError("An error occurred at CompressPDFUI in CompressPdfAsync: ", ex);
            }
        }


        private async void SaveCompressedFile()
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedPdfPath) || !File.Exists(_selectedPdfPath))
                {
                    MessageBox.Show("Please select a PDF file first.", "ToolDeck - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string outputFile = Path.Combine(fbd.SelectedPath, $"Compressed_{Path.GetFileName(_selectedPdfPath)}");

                    await CompressPdfAsync(_selectedPdfPath, outputFile);
                    MessageBox.Show("PDF compressed successfully!", "ToolDeck - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogError("An error occurred at CompressPDFUI in SaveCompressedFile: ", ex);
                MessageBox.Show("An error occurred while compressing the PDF.", "ToolDeck - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RenderPreviewAsync(string filePath)
        {
            try
            {
                panelPreview.Controls.Clear();

                await Task.Run(() =>
                {
                    using var doc = PdfiumViewer.PdfDocument.Load(filePath);
                    var image = doc.Render(0, 250, 350, true);

                    Invoke(new Action(() =>
                    {
                        PictureBox pb = new PictureBox
                        {
                            Image = image,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Width = 250,
                            Height = 350,
                            Margin = new Padding(5),
                            BackColor = Color.FromArgb(46, 46, 62)
                        };

                        panelPreview.Controls.Add(pb);
                    }));
                });
            }
            catch (Exception ex)
            {
                LogError("An error occurred at CompressPDFUI in RenderPreviewAsync: ", ex);
                MessageBox.Show("Could not preview PDF.", "ToolDeck - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //UI related codes

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            SelectFiles();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPanel();
        }

        private void btnCompressSave_Click(object sender, EventArgs e)
        {
            SaveCompressedFile();
        }
    }
}

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
    public partial class ProtectPDFUI : UserControl
    {
        private string _selectedPdfPath = string.Empty;
        private bool _preventPrinting = false;
        private bool _preventEditing = false;
        private bool _requirePassword = false;
        public ProtectPDFUI()
        {
            InitializeComponent();
        }

        private async void LoadSelectedPdf(string path)
        {
            _selectedPdfPath = path;
            await RenderPdfPagePreviewsAsync(path);
            panelPdfPreview.AllowDrop = true;
            panelPdfPreview.DragEnter += panelPdfPreview_DragEnter;
            panelPdfPreview.DragDrop += panelPdfPreview_DragDrop;
        }

        private async void SelectPDFFile()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PDF Files (*.pdf)|*.pdf";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        _selectedPdfPath = ofd.FileName;
                    }
                }
                await RenderPdfPagePreviewsAsync(_selectedPdfPath);
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ProtectPDFUI in SelectPDFFile: ", ex);
            }
        }

        private async void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedPdfPath) || !File.Exists(_selectedPdfPath))
                {
                    MessageBox.Show("Please select a valid PDF file.", "ToolDeck - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_requirePassword && string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter a password.", "ToolDeck - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = "Protected.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            await ApplyPdfProtection(_selectedPdfPath, sfd.FileName);
                            MessageBox.Show("PDF protected successfully!", "ToolDeck - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to protect PDF.", "ToolDeck - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LogError("An error occurred at ProtectPDFUI in Save#1: ", ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ProtectPDFUI in Save#2: ", ex);
            }
        }

        private async Task ApplyPdfProtection(string inputPath, string outputPath)
        {
            await Task.Run(() =>
            {
                try
                {
                    var writerProperties = new WriterProperties();
                    var passwordBytes = Encoding.UTF8.GetBytes(txtPassword.Text);

                    writerProperties.SetStandardEncryption(
                        passwordBytes, // user password
                        passwordBytes, // owner password
                        0, // No permissions granted
                        EncryptionConstants.ENCRYPTION_AES_128
                    );

                    using (var reader = new PdfReader(inputPath))
                    using (var writer = new PdfWriter(outputPath, writerProperties))
                    using (var pdfDoc = new PdfDocument(reader, writer))
                    {
                        pdfDoc.Close();
                    }
                }
                catch (Exception ex)
                {
                    LogError("An error occurred at ProtectPDFUI in ApplyPdfProtection: ", ex);
                }
            });
        }

        private void ClearAll()
        {
            try
            {
                // Dispose of controls and images inside the panel to free memory
                foreach (Control ctrl in panelPdfPreview.Controls)
                {
                    if (ctrl is Panel pnl)
                    {
                        foreach (Control innerCtrl in pnl.Controls)
                        {
                            if (innerCtrl is PictureBox pb && pb.Image != null)
                            {
                                pb.Image.Dispose();
                                pb.Image = null;
                            }
                        }

                        pnl.Dispose();
                    }
                }

                _selectedPdfPath = string.Empty;
                txtPassword.Clear();
                panelPdfPreview.Controls.Clear();
                // Force garbage collection
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ProtectPDFUI in ClearAll: ", ex);
            }
        }

        private async Task RenderPdfPagePreviewsAsync(string filePath)
        {
            try
            {
                panelPdfPreview.Controls.Clear();

                await Task.Run(() =>
                {
                    using var doc = PdfiumViewer.PdfDocument.Load(filePath);
                    var image = doc.Render(0, 250, 300, true);

                    Invoke(new Action(() =>
                    {
                        PictureBox pb = new PictureBox
                        {
                            Image = image,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Width = 250,
                            Height = 300,
                            Margin = new Padding(5),
                            BackColor = Color.FromArgb(46, 46, 62)
                        };

                        panelPdfPreview.Controls.Add(pb);
                    }));
                });
            }
            catch (Exception ex)
            {
                LogError("An error occurred at ProtectPDFUI in RenderPreviewAsync: ", ex);
                MessageBox.Show("Could not preview PDF.", "ToolDeck - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void panelPdfPreview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".pdf")
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void panelPdfPreview_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                if (Path.GetExtension(filePath).ToLower() == ".pdf")
                {
                    LoadSelectedPdf(filePath);
                }
                else
                {
                    MessageBox.Show("Only PDF files are supported.", "ToolDeck - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            SelectPDFFile();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}

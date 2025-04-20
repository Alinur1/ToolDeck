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

namespace ToolDeck
{
    public partial class SplitPDFUI : UserControl
    {
        private string _selectedPdfPath = string.Empty;

        public SplitPDFUI()
        {
            InitializeComponent();
        }

        private void SelectPDFFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files (*.pdf)|*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedPdfPath = ofd.FileName;
                    lblSelectedFile.Text = Path.GetFileName(_selectedPdfPath);
                }
            }
            RenderPdfPagePreviews(_selectedPdfPath);
        }

        private void SaveSplittedPDFFile()
        {
            if (string.IsNullOrEmpty(_selectedPdfPath) || !File.Exists(_selectedPdfPath))
            {
                MessageBox.Show("Please select a valid PDF file first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPageRanges.Text))
            {
                MessageBox.Show("Please enter a valid page range (e.g., 1-3,5-6).");
                return;
            }

            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string saveDirectory = fbd.SelectedPath;
                    try
                    {
                        SplitPdfByRanges(_selectedPdfPath, txtPageRanges.Text, saveDirectory);
                        MessageBox.Show("PDF split successfully!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error splitting PDF: " + ex.Message);
                    }
                }
            }
        }

        private void SplitPdfByRanges(string inputPath, string rangesText, string outputFolder)
        {
            using var reader = new PdfReader(inputPath);
            using var pdf = new PdfDocument(reader);
            int totalPages = pdf.GetNumberOfPages();

            var ranges = ParseRanges(rangesText, totalPages);

            int splitIndex = 1;
            foreach (var (start, end) in ranges)
            {
                string outputPath = Path.Combine(outputFolder, $"Split_{splitIndex++}.pdf");

                using var writer = new PdfWriter(outputPath);
                using var newPdf = new PdfDocument(writer);
                var merger = new PdfMerger(newPdf);

                merger.Merge(pdf, start, end);
            }
        }

        private List<(int start, int end)> ParseRanges(string input, int maxPages)
        {
            var ranges = new List<(int, int)>();
            var parts = input.Split(',');

            foreach (var part in parts)
            {
                if (part.Contains("-"))
                {
                    var bounds = part.Split('-');
                    int start = Math.Max(1, int.Parse(bounds[0]));
                    int end = Math.Min(maxPages, int.Parse(bounds[1]));
                    if (start <= end)
                        ranges.Add((start, end));
                }
                else
                {
                    int page = Math.Min(maxPages, Math.Max(1, int.Parse(part)));
                    ranges.Add((page, page));
                }
            }

            return ranges;
        }

        private void RenderPdfPagePreviews(string filePath)
        {
            panelPagePreview.Controls.Clear();

            using (var pdfDoc = PdfiumViewer.PdfDocument.Load(filePath))
            {
                for (int i = 0; i < pdfDoc.PageCount; i++)
                {
                    var image = pdfDoc.Render(i, 150, 250, true);

                    PictureBox pb = new PictureBox
                    {
                        Image = image,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 150,
                        Height = 250,
                        Margin = new Padding(5),
                        BackColor = Color.FromArgb(46, 46, 62)
                    };

                    Label lbl = new Label
                    {
                        Text = $"Page {i + 1}",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Width = pb.Width,
                        Height = 30,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(46, 46, 62)
                    };

                    var panel = new Panel
                    {
                        Width = pb.Width + 10,
                        Height = pb.Height + lbl.Height + 10,
                        BackColor = Color.FromArgb(46, 46, 62),
                        Margin = new Padding(10)
                    };

                    lbl.Top = pb.Bottom;
                    lbl.Left = 0;

                    panel.Controls.Add(pb);
                    panel.Controls.Add(lbl);

                    panelPagePreview.Controls.Add(panel);
                }
            }
        }




        //UI related code


        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            SelectPDFFile();
        }

        private void btnSplitSave_Click(object sender, EventArgs e)
        {
            SaveSplittedPDFFile();
        }
    }
}

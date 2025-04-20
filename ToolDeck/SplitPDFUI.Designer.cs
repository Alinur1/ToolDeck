namespace ToolDeck
{
    partial class SplitPDFUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectFile = new Button();
            lblSelectedFile = new Label();
            txtPageRanges = new TextBox();
            btnSplitSave = new Button();
            panelPagePreview = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Anchor = AnchorStyles.Top;
            btnSelectFile.BackColor = Color.Transparent;
            btnSelectFile.Cursor = Cursors.Hand;
            btnSelectFile.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnSelectFile.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSelectFile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSelectFile.FlatStyle = FlatStyle.Flat;
            btnSelectFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFile.ForeColor = Color.White;
            btnSelectFile.Location = new Point(48, 32);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(126, 52);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select PDF";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.Anchor = AnchorStyles.Top;
            lblSelectedFile.AutoSize = true;
            lblSelectedFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedFile.ForeColor = Color.White;
            lblSelectedFile.Location = new Point(48, 103);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(151, 21);
            lblSelectedFile.TabIndex = 3;
            lblSelectedFile.Text = "Selected file name";
            // 
            // txtPageRanges
            // 
            txtPageRanges.Anchor = AnchorStyles.Top;
            txtPageRanges.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPageRanges.Location = new Point(180, 46);
            txtPageRanges.Name = "txtPageRanges";
            txtPageRanges.PlaceholderText = "Intruction is given below";
            txtPageRanges.Size = new Size(411, 27);
            txtPageRanges.TabIndex = 1;
            // 
            // btnSplitSave
            // 
            btnSplitSave.Anchor = AnchorStyles.Top;
            btnSplitSave.BackColor = Color.Transparent;
            btnSplitSave.Cursor = Cursors.Hand;
            btnSplitSave.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnSplitSave.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSplitSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSplitSave.FlatStyle = FlatStyle.Flat;
            btnSplitSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSplitSave.ForeColor = Color.White;
            btnSplitSave.Location = new Point(597, 32);
            btnSplitSave.Name = "btnSplitSave";
            btnSplitSave.Size = new Size(126, 52);
            btnSplitSave.TabIndex = 2;
            btnSplitSave.Text = "Save";
            btnSplitSave.UseVisualStyleBackColor = false;
            btnSplitSave.Click += btnSplitSave_Click;
            // 
            // panelPagePreview
            // 
            panelPagePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPagePreview.AutoScroll = true;
            panelPagePreview.BorderStyle = BorderStyle.FixedSingle;
            panelPagePreview.Location = new Point(35, 193);
            panelPagePreview.Name = "panelPagePreview";
            panelPagePreview.Size = new Size(721, 312);
            panelPagePreview.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 133);
            label1.Name = "label1";
            label1.Size = new Size(295, 45);
            label1.TabIndex = 5;
            label1.Text = "Input: 1-2,5-6 → should create two PDFs\r\nInput: 4,7,9 → should create three one-pagers\r\nInput: 3-100 on a 10-page PDF → only goes to 10 safely";
            // 
            // SplitPDFUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(label1);
            Controls.Add(panelPagePreview);
            Controls.Add(btnSplitSave);
            Controls.Add(txtPageRanges);
            Controls.Add(lblSelectedFile);
            Controls.Add(btnSelectFile);
            Name = "SplitPDFUI";
            Size = new Size(807, 524);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label lblSelectedFile;
        private TextBox txtPageRanges;
        private Button btnSplitSave;
        private FlowLayoutPanel panelPagePreview;
        private Label label1;
    }
}

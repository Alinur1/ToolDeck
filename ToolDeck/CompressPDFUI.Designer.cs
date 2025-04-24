namespace ToolDeck
{
    partial class CompressPDFUI
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
            btnClear = new Button();
            panelPreview = new FlowLayoutPanel();
            lblOrDragDrop = new Label();
            btnCompressSave = new Button();
            btnSelectFiles = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top;
            btnClear.BackColor = Color.Transparent;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnClear.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(531, 25);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 52);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panelPreview
            // 
            panelPreview.AllowDrop = true;
            panelPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPreview.AutoScroll = true;
            panelPreview.BorderStyle = BorderStyle.FixedSingle;
            panelPreview.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPreview.ForeColor = Color.White;
            panelPreview.Location = new Point(15, 126);
            panelPreview.Name = "panelPreview";
            panelPreview.Size = new Size(776, 374);
            panelPreview.TabIndex = 6;
            // 
            // lblOrDragDrop
            // 
            lblOrDragDrop.Anchor = AnchorStyles.Top;
            lblOrDragDrop.AutoSize = true;
            lblOrDragDrop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrDragDrop.ForeColor = Color.White;
            lblOrDragDrop.Location = new Point(231, 102);
            lblOrDragDrop.Name = "lblOrDragDrop";
            lblOrDragDrop.Size = new Size(322, 21);
            lblOrDragDrop.TabIndex = 5;
            lblOrDragDrop.Text = "Select a file or drag and drop PDFs below";
            // 
            // btnCompressSave
            // 
            btnCompressSave.Anchor = AnchorStyles.Top;
            btnCompressSave.BackColor = Color.Transparent;
            btnCompressSave.Cursor = Cursors.Hand;
            btnCompressSave.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnCompressSave.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnCompressSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCompressSave.FlatStyle = FlatStyle.Flat;
            btnCompressSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompressSave.ForeColor = Color.White;
            btnCompressSave.Location = new Point(324, 25);
            btnCompressSave.Name = "btnCompressSave";
            btnCompressSave.Size = new Size(126, 52);
            btnCompressSave.TabIndex = 1;
            btnCompressSave.Text = "Save";
            btnCompressSave.UseVisualStyleBackColor = false;
            btnCompressSave.Click += btnCompressSave_Click;
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Anchor = AnchorStyles.Top;
            btnSelectFiles.BackColor = Color.Transparent;
            btnSelectFiles.Cursor = Cursors.Hand;
            btnSelectFiles.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnSelectFiles.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSelectFiles.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSelectFiles.FlatStyle = FlatStyle.Flat;
            btnSelectFiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFiles.ForeColor = Color.White;
            btnSelectFiles.Location = new Point(121, 25);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(126, 52);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // CompressPDFUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(btnClear);
            Controls.Add(panelPreview);
            Controls.Add(lblOrDragDrop);
            Controls.Add(btnCompressSave);
            Controls.Add(btnSelectFiles);
            Name = "CompressPDFUI";
            Size = new Size(807, 524);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private FlowLayoutPanel panelPreview;
        private Label lblOrDragDrop;
        private Button btnCompressSave;
        private Button btnSelectFiles;
    }
}

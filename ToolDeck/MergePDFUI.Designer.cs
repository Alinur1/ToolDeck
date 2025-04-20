namespace ToolDeck
{
    partial class MergePDF
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
            btnSelectFiles = new Button();
            btnSaveMerged = new Button();
            lblOrDragDrop = new Label();
            panelPdfPreview = new FlowLayoutPanel();
            btnClear = new Button();
            SuspendLayout();
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
            btnSelectFiles.Location = new Point(122, 33);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(126, 52);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // btnSaveMerged
            // 
            btnSaveMerged.Anchor = AnchorStyles.Top;
            btnSaveMerged.BackColor = Color.Transparent;
            btnSaveMerged.Cursor = Cursors.Hand;
            btnSaveMerged.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnSaveMerged.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSaveMerged.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSaveMerged.FlatStyle = FlatStyle.Flat;
            btnSaveMerged.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveMerged.ForeColor = Color.White;
            btnSaveMerged.Location = new Point(325, 33);
            btnSaveMerged.Name = "btnSaveMerged";
            btnSaveMerged.Size = new Size(126, 52);
            btnSaveMerged.TabIndex = 1;
            btnSaveMerged.Text = "Save";
            btnSaveMerged.UseVisualStyleBackColor = false;
            btnSaveMerged.Click += btnSaveMerged_Click;
            // 
            // lblOrDragDrop
            // 
            lblOrDragDrop.Anchor = AnchorStyles.Top;
            lblOrDragDrop.AutoSize = true;
            lblOrDragDrop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrDragDrop.ForeColor = Color.White;
            lblOrDragDrop.Location = new Point(287, 96);
            lblOrDragDrop.Name = "lblOrDragDrop";
            lblOrDragDrop.Size = new Size(212, 21);
            lblOrDragDrop.TabIndex = 3;
            lblOrDragDrop.Text = "Drag and drop PDFs below";
            // 
            // panelPdfPreview
            // 
            panelPdfPreview.AllowDrop = true;
            panelPdfPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPdfPreview.AutoScroll = true;
            panelPdfPreview.BorderStyle = BorderStyle.FixedSingle;
            panelPdfPreview.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPdfPreview.ForeColor = Color.White;
            panelPdfPreview.Location = new Point(16, 120);
            panelPdfPreview.Name = "panelPdfPreview";
            panelPdfPreview.Size = new Size(776, 388);
            panelPdfPreview.TabIndex = 4;
            panelPdfPreview.DragDrop += pnlPdfPreview_DragDrop;
            panelPdfPreview.DragEnter += pnlPdfPreview_DragEnter;
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
            btnClear.Location = new Point(532, 33);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 52);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // MergePDF
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(btnClear);
            Controls.Add(panelPdfPreview);
            Controls.Add(lblOrDragDrop);
            Controls.Add(btnSaveMerged);
            Controls.Add(btnSelectFiles);
            Name = "MergePDF";
            Size = new Size(807, 524);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFiles;
        private Button btnSaveMerged;
        private Label lblOrDragDrop;
        private FlowLayoutPanel panelPdfPreview;
        private Button btnClear;
    }
}

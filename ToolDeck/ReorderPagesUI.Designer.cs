namespace ToolDeck
{
    partial class ReorderPagesUI
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
            btnSave = new Button();
            btnSelectFiles = new Button();
            panelPdfPreview = new FlowLayoutPanel();
            lblOrDragDrop = new Label();
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
            btnClear.Location = new Point(484, 42);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 52);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnSave.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(318, 42);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 52);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnSelectFiles.Location = new Point(152, 42);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(126, 52);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // panelPdfPreview
            // 
            panelPdfPreview.AllowDrop = true;
            panelPdfPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPdfPreview.AutoScroll = true;
            panelPdfPreview.BorderStyle = BorderStyle.FixedSingle;
            panelPdfPreview.Location = new Point(22, 137);
            panelPdfPreview.Name = "panelPdfPreview";
            panelPdfPreview.Size = new Size(761, 372);
            panelPdfPreview.TabIndex = 4;
            panelPdfPreview.DragDrop += panelPdfPreview_DragDrop;
            panelPdfPreview.DragEnter += panelPdfPreview_DragEnter;
            panelPdfPreview.MouseDown += panelPdfPreview_MouseDown;
            // 
            // lblOrDragDrop
            // 
            lblOrDragDrop.Anchor = AnchorStyles.Top;
            lblOrDragDrop.AutoSize = true;
            lblOrDragDrop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrDragDrop.ForeColor = Color.White;
            lblOrDragDrop.Location = new Point(244, 113);
            lblOrDragDrop.Name = "lblOrDragDrop";
            lblOrDragDrop.Size = new Size(309, 21);
            lblOrDragDrop.TabIndex = 3;
            lblOrDragDrop.Text = "Select file or drag and drop PDFs below";
            // 
            // ReorderPagesUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(lblOrDragDrop);
            Controls.Add(panelPdfPreview);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnSelectFiles);
            Name = "ReorderPagesUI";
            Size = new Size(807, 524);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnSave;
        private Button btnSelectFiles;
        private FlowLayoutPanel panelPdfPreview;
        private Label lblOrDragDrop;
    }
}

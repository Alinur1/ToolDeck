namespace ToolDeck
{
    partial class ProtectPDFUI
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
            btnSave = new Button();
            btnClear = new Button();
            txtPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            panelPdfPreview = new FlowLayoutPanel();
            lblOrDragDrop = new Label();
            SuspendLayout();
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Anchor = AnchorStyles.None;
            btnSelectFiles.BackColor = Color.Transparent;
            btnSelectFiles.Cursor = Cursors.Hand;
            btnSelectFiles.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnSelectFiles.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSelectFiles.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSelectFiles.FlatStyle = FlatStyle.Flat;
            btnSelectFiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFiles.ForeColor = Color.White;
            btnSelectFiles.Location = new Point(114, 211);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(126, 52);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnSave.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(114, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 52);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.Transparent;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnClear.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(114, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 52);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(218, 62);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(483, 29);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.Anchor = AnchorStyles.None;
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxShowPassword.ForeColor = Color.White;
            checkBoxShowPassword.Location = new Point(218, 97);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(118, 21);
            checkBoxShowPassword.TabIndex = 5;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // panelPdfPreview
            // 
            panelPdfPreview.AllowDrop = true;
            panelPdfPreview.Anchor = AnchorStyles.None;
            panelPdfPreview.AutoScroll = true;
            panelPdfPreview.BorderStyle = BorderStyle.FixedSingle;
            panelPdfPreview.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPdfPreview.ForeColor = Color.White;
            panelPdfPreview.Location = new Point(314, 165);
            panelPdfPreview.Name = "panelPdfPreview";
            panelPdfPreview.Size = new Size(280, 329);
            panelPdfPreview.TabIndex = 7;
            panelPdfPreview.DragDrop += panelPdfPreview_DragDrop;
            panelPdfPreview.DragEnter += panelPdfPreview_DragEnter;
            // 
            // lblOrDragDrop
            // 
            lblOrDragDrop.Anchor = AnchorStyles.None;
            lblOrDragDrop.AutoSize = true;
            lblOrDragDrop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrDragDrop.ForeColor = Color.White;
            lblOrDragDrop.Location = new Point(303, 141);
            lblOrDragDrop.Name = "lblOrDragDrop";
            lblOrDragDrop.Size = new Size(309, 21);
            lblOrDragDrop.TabIndex = 6;
            lblOrDragDrop.Text = "Select file or drag and drop PDFs below";
            // 
            // ProtectPDFUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(lblOrDragDrop);
            Controls.Add(panelPdfPreview);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnSelectFiles);
            Name = "ProtectPDFUI";
            Size = new Size(807, 524);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFiles;
        private Button btnSave;
        private Button btnClear;
        private TextBox txtPassword;
        private CheckBox checkBoxShowPassword;
        private FlowLayoutPanel panelPdfPreview;
        private Label lblOrDragDrop;
    }
}

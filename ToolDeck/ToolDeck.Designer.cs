namespace ToolDeck
{
    partial class ToolDeck
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolDeck));
            tabToolDeck = new TabControl();
            tabClockPage = new TabPage();
            panelClock = new Panel();
            ClockTabBtnPanelContainer = new FlowLayoutPanel();
            btnClock = new Button();
            btnTimer = new Button();
            btnStopwatch = new Button();
            tabPDFToolsPage = new TabPage();
            tabFileConversionPage = new TabPage();
            tabBarcodeScannerPage = new TabPage();
            tabDocScannerPage = new TabPage();
            tabImgBgRemovePage = new TabPage();
            tabToolDeck.SuspendLayout();
            tabClockPage.SuspendLayout();
            ClockTabBtnPanelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tabToolDeck
            // 
            tabToolDeck.Controls.Add(tabClockPage);
            tabToolDeck.Controls.Add(tabPDFToolsPage);
            tabToolDeck.Controls.Add(tabFileConversionPage);
            tabToolDeck.Controls.Add(tabBarcodeScannerPage);
            tabToolDeck.Controls.Add(tabDocScannerPage);
            tabToolDeck.Controls.Add(tabImgBgRemovePage);
            tabToolDeck.Dock = DockStyle.Fill;
            tabToolDeck.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabToolDeck.Location = new Point(0, 0);
            tabToolDeck.Name = "tabToolDeck";
            tabToolDeck.SelectedIndex = 0;
            tabToolDeck.Size = new Size(1020, 560);
            tabToolDeck.TabIndex = 0;
            // 
            // tabClockPage
            // 
            tabClockPage.BackColor = Color.Transparent;
            tabClockPage.Controls.Add(panelClock);
            tabClockPage.Controls.Add(ClockTabBtnPanelContainer);
            tabClockPage.Location = new Point(4, 26);
            tabClockPage.Name = "tabClockPage";
            tabClockPage.Padding = new Padding(3);
            tabClockPage.Size = new Size(1012, 530);
            tabClockPage.TabIndex = 0;
            tabClockPage.Text = "Clock";
            // 
            // panelClock
            // 
            panelClock.BackColor = Color.FromArgb(46, 46, 62);
            panelClock.Dock = DockStyle.Fill;
            panelClock.Location = new Point(202, 3);
            panelClock.Name = "panelClock";
            panelClock.Size = new Size(807, 524);
            panelClock.TabIndex = 1;
            // 
            // ClockTabBtnPanelContainer
            // 
            ClockTabBtnPanelContainer.BackColor = Color.FromArgb(102, 102, 105);
            ClockTabBtnPanelContainer.Controls.Add(btnClock);
            ClockTabBtnPanelContainer.Controls.Add(btnTimer);
            ClockTabBtnPanelContainer.Controls.Add(btnStopwatch);
            ClockTabBtnPanelContainer.Dock = DockStyle.Left;
            ClockTabBtnPanelContainer.Location = new Point(3, 3);
            ClockTabBtnPanelContainer.Name = "ClockTabBtnPanelContainer";
            ClockTabBtnPanelContainer.Size = new Size(199, 524);
            ClockTabBtnPanelContainer.TabIndex = 0;
            // 
            // btnClock
            // 
            btnClock.Cursor = Cursors.Hand;
            btnClock.FlatAppearance.BorderColor = Color.White;
            btnClock.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnClock.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClock.FlatStyle = FlatStyle.Flat;
            btnClock.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClock.ForeColor = Color.White;
            btnClock.Location = new Point(3, 3);
            btnClock.Name = "btnClock";
            btnClock.Size = new Size(182, 45);
            btnClock.TabIndex = 0;
            btnClock.Text = "Clock";
            btnClock.UseVisualStyleBackColor = true;
            btnClock.Click += btnClock_Click;
            // 
            // btnTimer
            // 
            btnTimer.Cursor = Cursors.Hand;
            btnTimer.FlatAppearance.BorderColor = Color.White;
            btnTimer.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnTimer.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnTimer.FlatStyle = FlatStyle.Flat;
            btnTimer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimer.ForeColor = Color.White;
            btnTimer.Location = new Point(3, 54);
            btnTimer.Name = "btnTimer";
            btnTimer.Size = new Size(182, 45);
            btnTimer.TabIndex = 1;
            btnTimer.Text = "Timer";
            btnTimer.UseVisualStyleBackColor = true;
            // 
            // btnStopwatch
            // 
            btnStopwatch.Cursor = Cursors.Hand;
            btnStopwatch.FlatAppearance.BorderColor = Color.White;
            btnStopwatch.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnStopwatch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnStopwatch.FlatStyle = FlatStyle.Flat;
            btnStopwatch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStopwatch.ForeColor = Color.White;
            btnStopwatch.Location = new Point(3, 105);
            btnStopwatch.Name = "btnStopwatch";
            btnStopwatch.Size = new Size(182, 45);
            btnStopwatch.TabIndex = 2;
            btnStopwatch.Text = "Stopwatch";
            btnStopwatch.UseVisualStyleBackColor = true;
            // 
            // tabPDFToolsPage
            // 
            tabPDFToolsPage.BackColor = Color.FromArgb(102, 102, 105);
            tabPDFToolsPage.Location = new Point(4, 26);
            tabPDFToolsPage.Name = "tabPDFToolsPage";
            tabPDFToolsPage.Padding = new Padding(3);
            tabPDFToolsPage.Size = new Size(1012, 530);
            tabPDFToolsPage.TabIndex = 1;
            tabPDFToolsPage.Text = "PDF Tools";
            // 
            // tabFileConversionPage
            // 
            tabFileConversionPage.BackColor = Color.FromArgb(102, 102, 105);
            tabFileConversionPage.Location = new Point(4, 26);
            tabFileConversionPage.Name = "tabFileConversionPage";
            tabFileConversionPage.Padding = new Padding(3);
            tabFileConversionPage.Size = new Size(1012, 530);
            tabFileConversionPage.TabIndex = 2;
            tabFileConversionPage.Text = "File Conversion";
            // 
            // tabBarcodeScannerPage
            // 
            tabBarcodeScannerPage.BackColor = Color.FromArgb(102, 102, 105);
            tabBarcodeScannerPage.Location = new Point(4, 26);
            tabBarcodeScannerPage.Name = "tabBarcodeScannerPage";
            tabBarcodeScannerPage.Padding = new Padding(3);
            tabBarcodeScannerPage.Size = new Size(1012, 530);
            tabBarcodeScannerPage.TabIndex = 3;
            tabBarcodeScannerPage.Text = "QR/Barcode Scanner/Reader";
            // 
            // tabDocScannerPage
            // 
            tabDocScannerPage.BackColor = Color.FromArgb(102, 102, 105);
            tabDocScannerPage.Location = new Point(4, 26);
            tabDocScannerPage.Name = "tabDocScannerPage";
            tabDocScannerPage.Padding = new Padding(3);
            tabDocScannerPage.Size = new Size(1012, 530);
            tabDocScannerPage.TabIndex = 4;
            tabDocScannerPage.Text = "Document Scanner";
            // 
            // tabImgBgRemovePage
            // 
            tabImgBgRemovePage.BackColor = Color.FromArgb(102, 102, 105);
            tabImgBgRemovePage.Location = new Point(4, 26);
            tabImgBgRemovePage.Name = "tabImgBgRemovePage";
            tabImgBgRemovePage.Padding = new Padding(3);
            tabImgBgRemovePage.Size = new Size(1012, 530);
            tabImgBgRemovePage.TabIndex = 5;
            tabImgBgRemovePage.Text = "Image Background Remover";
            // 
            // ToolDeck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 102, 105);
            ClientSize = new Size(1020, 560);
            Controls.Add(tabToolDeck);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(899, 499);
            Name = "ToolDeck";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToolDeck";
            tabToolDeck.ResumeLayout(false);
            tabClockPage.ResumeLayout(false);
            ClockTabBtnPanelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabToolDeck;
        private TabPage tabClockPage;
        private TabPage tabPDFToolsPage;
        private TabPage tabFileConversionPage;
        private TabPage tabBarcodeScannerPage;
        private TabPage tabDocScannerPage;
        private TabPage tabImgBgRemovePage;
        private FlowLayoutPanel ClockTabBtnPanelContainer;
        private Button btnClock;
        private Button btnTimer;
        private Button btnStopwatch;
        private Panel panelClock;
    }
}

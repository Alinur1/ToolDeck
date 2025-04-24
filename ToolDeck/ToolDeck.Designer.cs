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
            panelPDFTools = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMergePDF = new Button();
            btnSplitPDF = new Button();
            btnCompressPDF = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            tabFileConversionPage = new TabPage();
            tabBarcodeScannerPage = new TabPage();
            tabDocScannerPage = new TabPage();
            tabImgBgRemovePage = new TabPage();
            tabToolDeck.SuspendLayout();
            tabClockPage.SuspendLayout();
            ClockTabBtnPanelContainer.SuspendLayout();
            tabPDFToolsPage.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            btnTimer.Click += btnTimer_Click;
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
            btnStopwatch.Click += btnStopwatch_Click;
            // 
            // tabPDFToolsPage
            // 
            tabPDFToolsPage.BackColor = Color.FromArgb(102, 102, 105);
            tabPDFToolsPage.Controls.Add(panelPDFTools);
            tabPDFToolsPage.Controls.Add(flowLayoutPanel1);
            tabPDFToolsPage.Location = new Point(4, 26);
            tabPDFToolsPage.Name = "tabPDFToolsPage";
            tabPDFToolsPage.Padding = new Padding(3);
            tabPDFToolsPage.Size = new Size(1012, 530);
            tabPDFToolsPage.TabIndex = 1;
            tabPDFToolsPage.Text = "PDF Tools";
            // 
            // panelPDFTools
            // 
            panelPDFTools.BackColor = Color.FromArgb(46, 46, 62);
            panelPDFTools.Dock = DockStyle.Fill;
            panelPDFTools.Location = new Point(202, 3);
            panelPDFTools.Name = "panelPDFTools";
            panelPDFTools.Size = new Size(807, 524);
            panelPDFTools.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(102, 102, 105);
            flowLayoutPanel1.Controls.Add(btnMergePDF);
            flowLayoutPanel1.Controls.Add(btnSplitPDF);
            flowLayoutPanel1.Controls.Add(btnCompressPDF);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(199, 524);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMergePDF
            // 
            btnMergePDF.Cursor = Cursors.Hand;
            btnMergePDF.FlatAppearance.BorderColor = Color.White;
            btnMergePDF.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnMergePDF.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMergePDF.FlatStyle = FlatStyle.Flat;
            btnMergePDF.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMergePDF.ForeColor = Color.White;
            btnMergePDF.Location = new Point(3, 3);
            btnMergePDF.Name = "btnMergePDF";
            btnMergePDF.Size = new Size(182, 45);
            btnMergePDF.TabIndex = 0;
            btnMergePDF.Text = "Merge PDF";
            btnMergePDF.UseVisualStyleBackColor = true;
            btnMergePDF.Click += btnMergePDF_Click;
            // 
            // btnSplitPDF
            // 
            btnSplitPDF.Cursor = Cursors.Hand;
            btnSplitPDF.FlatAppearance.BorderColor = Color.White;
            btnSplitPDF.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSplitPDF.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSplitPDF.FlatStyle = FlatStyle.Flat;
            btnSplitPDF.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSplitPDF.ForeColor = Color.White;
            btnSplitPDF.Location = new Point(3, 54);
            btnSplitPDF.Name = "btnSplitPDF";
            btnSplitPDF.Size = new Size(182, 45);
            btnSplitPDF.TabIndex = 1;
            btnSplitPDF.Text = "Split PDF pages";
            btnSplitPDF.UseVisualStyleBackColor = true;
            btnSplitPDF.Click += btnSplitPDF_Click;
            // 
            // btnCompressPDF
            // 
            btnCompressPDF.Cursor = Cursors.Hand;
            btnCompressPDF.FlatAppearance.BorderColor = Color.White;
            btnCompressPDF.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnCompressPDF.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCompressPDF.FlatStyle = FlatStyle.Flat;
            btnCompressPDF.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompressPDF.ForeColor = Color.White;
            btnCompressPDF.Location = new Point(3, 105);
            btnCompressPDF.Name = "btnCompressPDF";
            btnCompressPDF.Size = new Size(182, 45);
            btnCompressPDF.TabIndex = 2;
            btnCompressPDF.Text = "Compress PDF size";
            btnCompressPDF.UseVisualStyleBackColor = true;
            btnCompressPDF.Click += btnCompressPDF_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 156);
            button4.Name = "button4";
            button4.Size = new Size(182, 45);
            button4.TabIndex = 3;
            button4.Text = "Protect PDF";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 207);
            button5.Name = "button5";
            button5.Size = new Size(182, 45);
            button5.TabIndex = 4;
            button5.Text = "Sort/reorder pages";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button6.FlatAppearance.MouseOverBackColor = Color.Silver;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 258);
            button6.Name = "button6";
            button6.Size = new Size(182, 45);
            button6.TabIndex = 5;
            button6.Text = "Sign PDFs";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button7.FlatAppearance.MouseOverBackColor = Color.Silver;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 309);
            button7.Name = "button7";
            button7.Size = new Size(182, 45);
            button7.TabIndex = 6;
            button7.Text = "Freehand annotations";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button8.FlatAppearance.MouseOverBackColor = Color.Silver;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(3, 360);
            button8.Name = "button8";
            button8.Size = new Size(182, 45);
            button8.TabIndex = 7;
            button8.Text = "Watermark";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.White;
            button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button9.FlatAppearance.MouseOverBackColor = Color.Silver;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(3, 411);
            button9.Name = "button9";
            button9.Size = new Size(182, 45);
            button9.TabIndex = 8;
            button9.Text = "Page numbers";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.White;
            button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button10.FlatAppearance.MouseOverBackColor = Color.Silver;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(3, 462);
            button10.Name = "button10";
            button10.Size = new Size(182, 45);
            button10.TabIndex = 9;
            button10.Text = "Edit PDF";
            button10.UseVisualStyleBackColor = true;
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
            tabPDFToolsPage.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMergePDF;
        private Button btnSplitPDF;
        private Button btnCompressPDF;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel panelPDFTools;
    }
}

namespace ToolDeck
{
    partial class StopWatchUI
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
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            btnStartStop = new Button();
            btnLap = new Button();
            btnReset = new Button();
            lstLaps = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(321, 45);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(147, 32);
            lblTime.TabIndex = 7;
            lblTime.Text = "00:00:00.00";
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.None;
            btnStartStop.BackColor = Color.Transparent;
            btnStartStop.Cursor = Cursors.Hand;
            btnStartStop.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnStartStop.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnStartStop.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartStop.ForeColor = Color.White;
            btnStartStop.Location = new Point(155, 93);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(126, 52);
            btnStartStop.TabIndex = 8;
            btnStartStop.Text = "Start/Stop";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnLap
            // 
            btnLap.Anchor = AnchorStyles.None;
            btnLap.BackColor = Color.Transparent;
            btnLap.Cursor = Cursors.Hand;
            btnLap.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnLap.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnLap.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLap.FlatStyle = FlatStyle.Flat;
            btnLap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLap.ForeColor = Color.White;
            btnLap.Location = new Point(329, 93);
            btnLap.Name = "btnLap";
            btnLap.Size = new Size(126, 52);
            btnLap.TabIndex = 9;
            btnLap.Text = "Lap";
            btnLap.UseVisualStyleBackColor = false;
            btnLap.Click += btnLap_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = Color.Transparent;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnReset.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnReset.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(503, 93);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(126, 52);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lstLaps
            // 
            lstLaps.Anchor = AnchorStyles.None;
            lstLaps.BackColor = Color.FromArgb(46, 46, 62);
            lstLaps.BorderStyle = BorderStyle.None;
            lstLaps.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstLaps.ForeColor = Color.White;
            lstLaps.FormattingEnabled = true;
            lstLaps.ItemHeight = 25;
            lstLaps.Location = new Point(161, 157);
            lstLaps.Name = "lstLaps";
            lstLaps.SelectionMode = SelectionMode.MultiSimple;
            lstLaps.Size = new Size(458, 350);
            lstLaps.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // StopWatchUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(lstLaps);
            Controls.Add(btnReset);
            Controls.Add(btnLap);
            Controls.Add(btnStartStop);
            Controls.Add(lblTime);
            Name = "StopWatchUI";
            Size = new Size(807, 524);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Button btnStartStop;
        private Button btnLap;
        private Button btnReset;
        private ListBox lstLaps;
        private System.Windows.Forms.Timer timer1;
    }
}

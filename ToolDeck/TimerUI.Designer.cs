namespace ToolDeck
{
    partial class TimerUI
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
            numSecond = new NumericUpDown();
            numMinute = new NumericUpDown();
            labelSetSeconds = new Label();
            labelSetMinutes = new Label();
            labelTimer = new Label();
            btnStart = new Button();
            btnPause = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            numHour = new NumericUpDown();
            labelSetHours = new Label();
            labelSetDays = new Label();
            numDay = new NumericUpDown();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)numSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDay).BeginInit();
            SuspendLayout();
            // 
            // numSecond
            // 
            numSecond.Anchor = AnchorStyles.None;
            numSecond.BackColor = Color.Silver;
            numSecond.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSecond.Location = new Point(485, 129);
            numSecond.Name = "numSecond";
            numSecond.Size = new Size(90, 43);
            numSecond.TabIndex = 3;
            numSecond.TextAlign = HorizontalAlignment.Center;
            // 
            // numMinute
            // 
            numMinute.Anchor = AnchorStyles.None;
            numMinute.BackColor = Color.Silver;
            numMinute.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMinute.Location = new Point(389, 129);
            numMinute.Name = "numMinute";
            numMinute.Size = new Size(90, 43);
            numMinute.TabIndex = 2;
            numMinute.TextAlign = HorizontalAlignment.Center;
            // 
            // labelSetSeconds
            // 
            labelSetSeconds.Anchor = AnchorStyles.None;
            labelSetSeconds.AutoSize = true;
            labelSetSeconds.ForeColor = Color.White;
            labelSetSeconds.Location = new Point(502, 175);
            labelSetSeconds.Name = "labelSetSeconds";
            labelSetSeconds.Size = new Size(51, 15);
            labelSetSeconds.TabIndex = 4;
            labelSetSeconds.Text = "Seconds";
            // 
            // labelSetMinutes
            // 
            labelSetMinutes.Anchor = AnchorStyles.None;
            labelSetMinutes.AutoSize = true;
            labelSetMinutes.ForeColor = Color.White;
            labelSetMinutes.Location = new Point(399, 175);
            labelSetMinutes.Name = "labelSetMinutes";
            labelSetMinutes.Size = new Size(50, 15);
            labelSetMinutes.TabIndex = 5;
            labelSetMinutes.Text = "Minutes";
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.None;
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimer.ForeColor = Color.White;
            labelTimer.Location = new Point(313, 225);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(147, 32);
            labelTimer.TabIndex = 4;
            labelTimer.Text = "00:00:00:00";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.BackColor = Color.Transparent;
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnStart.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnStart.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 14.25F);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(185, 292);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(118, 55);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            btnPause.Anchor = AnchorStyles.None;
            btnPause.BackColor = Color.Transparent;
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.Cursor = Cursors.Hand;
            btnPause.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnPause.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnPause.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnPause.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Segoe UI", 14.25F);
            btnPause.ForeColor = Color.White;
            btnPause.Location = new Point(330, 292);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(118, 55);
            btnPause.TabIndex = 6;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // numHour
            // 
            numHour.Anchor = AnchorStyles.None;
            numHour.BackColor = Color.Silver;
            numHour.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numHour.Location = new Point(293, 129);
            numHour.Name = "numHour";
            numHour.Size = new Size(90, 43);
            numHour.TabIndex = 1;
            numHour.TextAlign = HorizontalAlignment.Center;
            // 
            // labelSetHours
            // 
            labelSetHours.Anchor = AnchorStyles.None;
            labelSetHours.AutoSize = true;
            labelSetHours.ForeColor = Color.White;
            labelSetHours.Location = new Point(307, 175);
            labelSetHours.Name = "labelSetHours";
            labelSetHours.Size = new Size(39, 15);
            labelSetHours.TabIndex = 3;
            labelSetHours.Text = "Hours";
            // 
            // labelSetDays
            // 
            labelSetDays.Anchor = AnchorStyles.None;
            labelSetDays.AutoSize = true;
            labelSetDays.ForeColor = Color.White;
            labelSetDays.Location = new Point(222, 175);
            labelSetDays.Name = "labelSetDays";
            labelSetDays.Size = new Size(32, 15);
            labelSetDays.TabIndex = 10;
            labelSetDays.Text = "Days";
            // 
            // numDay
            // 
            numDay.Anchor = AnchorStyles.None;
            numDay.BackColor = Color.Silver;
            numDay.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDay.Location = new Point(197, 129);
            numDay.Name = "numDay";
            numDay.Size = new Size(90, 43);
            numDay.TabIndex = 0;
            numDay.TextAlign = HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = Color.Transparent;
            btnReset.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 126);
            btnReset.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnReset.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnReset.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 14.25F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(473, 292);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 55);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // TimerUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(btnReset);
            Controls.Add(labelSetDays);
            Controls.Add(numDay);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Controls.Add(labelTimer);
            Controls.Add(labelSetMinutes);
            Controls.Add(labelSetSeconds);
            Controls.Add(labelSetHours);
            Controls.Add(numMinute);
            Controls.Add(numSecond);
            Controls.Add(numHour);
            Name = "TimerUI";
            Size = new Size(807, 524);
            ((System.ComponentModel.ISupportInitialize)numSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numSecond;
        private NumericUpDown numMinute;
        private Label labelSetSeconds;
        private Label labelSetMinutes;
        private Label labelTimer;
        private Button btnStart;
        private Button btnPause;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numHour;
        private Label labelSetHours;
        private Label labelSetDays;
        private NumericUpDown numDay;
        private Button btnReset;
    }
}

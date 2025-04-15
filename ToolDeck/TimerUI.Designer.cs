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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerUI));
            numHour = new NumericUpDown();
            numSecond = new NumericUpDown();
            numMinute = new NumericUpDown();
            labelSetHours = new Label();
            labelSetSeconds = new Label();
            labelSetMinutes = new Label();
            labelTimer = new Label();
            btnStart = new Button();
            btnStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).BeginInit();
            SuspendLayout();
            // 
            // numHour
            // 
            numHour.Anchor = AnchorStyles.None;
            numHour.BackColor = Color.Silver;
            numHour.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numHour.Location = new Point(253, 127);
            numHour.Name = "numHour";
            numHour.Size = new Size(90, 43);
            numHour.TabIndex = 0;
            // 
            // numSecond
            // 
            numSecond.Anchor = AnchorStyles.None;
            numSecond.BackColor = Color.Silver;
            numSecond.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSecond.Location = new Point(445, 127);
            numSecond.Name = "numSecond";
            numSecond.Size = new Size(90, 43);
            numSecond.TabIndex = 1;
            // 
            // numMinute
            // 
            numMinute.Anchor = AnchorStyles.None;
            numMinute.BackColor = Color.Silver;
            numMinute.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMinute.Location = new Point(349, 127);
            numMinute.Name = "numMinute";
            numMinute.Size = new Size(90, 43);
            numMinute.TabIndex = 2;
            // 
            // labelSetHours
            // 
            labelSetHours.Anchor = AnchorStyles.None;
            labelSetHours.AutoSize = true;
            labelSetHours.ForeColor = Color.White;
            labelSetHours.Location = new Point(278, 173);
            labelSetHours.Name = "labelSetHours";
            labelSetHours.Size = new Size(39, 15);
            labelSetHours.TabIndex = 3;
            labelSetHours.Text = "Hours";
            // 
            // labelSetSeconds
            // 
            labelSetSeconds.Anchor = AnchorStyles.None;
            labelSetSeconds.AutoSize = true;
            labelSetSeconds.ForeColor = Color.White;
            labelSetSeconds.Location = new Point(462, 173);
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
            labelSetMinutes.Location = new Point(370, 173);
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
            labelTimer.Location = new Point(336, 225);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(112, 32);
            labelTimer.TabIndex = 6;
            labelTimer.Text = "00:00:00";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.BackColor = Color.Transparent;
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnStart.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(306, 292);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(57, 55);
            btnStart.TabIndex = 7;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.None;
            btnStop.BackColor = Color.Transparent;
            btnStop.BackgroundImage = (Image)resources.GetObject("btnStop.BackgroundImage");
            btnStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.Cursor = Cursors.Hand;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnStop.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnStop.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Location = new Point(398, 287);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(67, 64);
            btnStop.TabIndex = 8;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // TimerUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(btnStop);
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
            ((System.ComponentModel.ISupportInitialize)numHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numHour;
        private NumericUpDown numSecond;
        private NumericUpDown numMinute;
        private Label labelSetHours;
        private Label labelSetSeconds;
        private Label labelSetMinutes;
        private Label labelTimer;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer timer1;
    }
}

namespace ToolDeck
{
    partial class Clock
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
            labelDay = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            labelAdvice = new Label();
            labelTime = new Label();
            labelDate = new Label();
            labelTimeZone = new Label();
            SuspendLayout();
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.FlatStyle = FlatStyle.Flat;
            labelDay.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDay.ForeColor = Color.White;
            labelDay.Location = new Point(14, 15);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(70, 40);
            labelDay.TabIndex = 0;
            labelDay.Text = "Day";
            // 
            // timerClock
            // 
            timerClock.Tick += timerClock_Tick;
            // 
            // labelAdvice
            // 
            labelAdvice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelAdvice.AutoSize = true;
            labelAdvice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdvice.ForeColor = Color.White;
            labelAdvice.Location = new Point(14, 491);
            labelAdvice.Name = "labelAdvice";
            labelAdvice.Size = new Size(98, 21);
            labelAdvice.TabIndex = 1;
            labelAdvice.Text = "Short Advice";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.FlatStyle = FlatStyle.Flat;
            labelTime.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(14, 135);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(431, 40);
            labelTime.TabIndex = 2;
            labelTime.Text = "Hour, Minute, Second AM/PM";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.FlatStyle = FlatStyle.Flat;
            labelDate.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(14, 75);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(264, 40);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date, Month, Year";
            // 
            // labelTimeZone
            // 
            labelTimeZone.AutoSize = true;
            labelTimeZone.FlatStyle = FlatStyle.Flat;
            labelTimeZone.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimeZone.ForeColor = Color.White;
            labelTimeZone.Location = new Point(14, 195);
            labelTimeZone.Name = "labelTimeZone";
            labelTimeZone.Size = new Size(117, 30);
            labelTimeZone.TabIndex = 4;
            labelTimeZone.Text = "Time Zone";
            // 
            // Clock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 62);
            Controls.Add(labelTimeZone);
            Controls.Add(labelDate);
            Controls.Add(labelTime);
            Controls.Add(labelAdvice);
            Controls.Add(labelDay);
            Name = "Clock";
            Size = new Size(807, 524);
            Load += Clock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDay;
        private System.Windows.Forms.Timer timerClock;
        private Label labelAdvice;
        private Label labelTime;
        private Label labelDate;
        private Label labelTimeZone;
    }
}

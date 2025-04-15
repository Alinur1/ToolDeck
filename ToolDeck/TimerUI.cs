﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolDeck
{
    public partial class TimerUI : UserControl
    {
        private TimeSpan remainingTime;
        public TimerUI()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            labelTimer.Text = "00:00:00";
        }

        private void TimerStart()
        {
            int hour = (int)numHour.Value;
            int minute = (int)numMinute.Value;
            int second = (int)numSecond.Value;

            remainingTime = new TimeSpan(hour, minute, second);

            if (remainingTime.TotalSeconds > 0)
            {
                labelTimer.Text = remainingTime.ToString(@"hh\:mm\:ss");
                timer1.Start();
            }
        }

        private void timerTick()
        {
            if (remainingTime.TotalSeconds > 1)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                labelTimer.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer1.Stop();
                PlayAlarmSound();
                labelTimer.Text = "00:00:00";
                MessageBox.Show("⏰ Time's up!", "ToolDeck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PlayAlarmSound()
        {
            SystemSounds.Exclamation.Play();
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            TimerStart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTick();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            labelTimer.Text = "00:00:00";
        }
    }
}

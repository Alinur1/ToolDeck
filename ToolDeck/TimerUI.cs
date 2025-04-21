using System;
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
            labelTimer.Text = "00:00:00:00";
        }

        private void TimerStart()
        {
            int day = (int)numDay.Value;
            int hour = (int)numHour.Value;
            int minute = (int)numMinute.Value;
            int second = (int)numSecond.Value;

            remainingTime = new TimeSpan(day, hour, minute, second);

            if (remainingTime.TotalSeconds > 0)
            {
                labelTimer.Text = remainingTime.ToString(@"dd\:hh\:mm\:ss");
                timer1.Start();
                hideUI();
                btnStart.Enabled = false;
            }
        }

        private void timerTick()
        {
            if (remainingTime.TotalSeconds > 1)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                labelTimer.Text = remainingTime.ToString(@"dd\:hh\:mm\:ss");
            }
            else
            {
                timer1.Stop();
                PlayAlarmSound();
                labelTimer.Text = "00:00:00:00";
                showUI();
                btnStart.Enabled = true;
                MessageBox.Show("⏰ Time's up!", "ToolDeck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PlayAlarmSound()
        {
            SystemSounds.Exclamation.Play();
        }

        private void hideUI()
        {
            numDay.Visible = false;
            numHour.Visible = false;
            numMinute.Visible = false;
            numSecond.Visible = false;
            labelSetDays.Visible = false;
            labelSetHours.Visible = false;
            labelSetMinutes.Visible = false;
            labelSetSeconds.Visible = false;
        }

        private void showUI()
        {
            numDay.Visible = true;
            numHour.Visible = true;
            numMinute.Visible = true;
            numSecond.Visible = true;
            labelSetDays.Visible = true;
            labelSetHours.Visible = true;
            labelSetMinutes.Visible = true;
            labelSetSeconds.Visible = true;
        }

        private void blankCheck()
        {
            if(string.IsNullOrWhiteSpace(numDay.Text))
            {
                numDay.Value = 0;
            }
            else if(string.IsNullOrWhiteSpace(numHour.Text))
            {
                numHour.Value = 0;
            }
            else if(string.IsNullOrWhiteSpace(numMinute.Text))
            {
                numMinute.Value = 0;
            }
            else if(string.IsNullOrWhiteSpace(numSecond.Text))
            {
                numSecond.Value = 0;
            }
            TimerStart();
        }




        // UI related code

        private void btnStart_Click(object sender, EventArgs e)
        {
            blankCheck();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTick();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            labelTimer.Text = "00:00:00:00";
            showUI();
            btnStart.Enabled = true;
        }
    }
}

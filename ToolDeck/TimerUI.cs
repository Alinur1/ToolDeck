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
using static ToolDeck.Logger;

namespace ToolDeck
{
    public partial class TimerUI : UserControl
    {
        private TimeSpan remainingTime;
        private bool isPaused = false;

        public TimerUI()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            labelTimer.Text = "00:00:00:00";
            btnPause.Enabled = false;
        }

        private void TimerStart()
        {
            try
            {
                if(!isPaused)
                {
                    int day = (int)numDay.Value;
                    int hour = (int)numHour.Value;
                    int minute = (int)numMinute.Value;
                    int second = (int)numSecond.Value;

                    remainingTime = new TimeSpan(day, hour, minute, second);
                }

                if (remainingTime.TotalSeconds > 0)
                {
                    labelTimer.Text = remainingTime.ToString(@"dd\:hh\:mm\:ss");
                    timer1.Start();
                    hideUI();
                    btnStart.Enabled = false;
                    btnPause.Enabled = true;
                    isPaused = false;
                }
            }
            catch (Exception ex)
            {
                LogError("An error occurred at TimerUI in TimerStart: ", ex);
            }
        }

        private void timerTick()
        {
            try
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
                    MessageBox.Show("⏰ Time's up!", "ToolDeck - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogError("An error occurred at TimerUI in timerTick: ", ex);
            }
        }

        private void PlayAlarmSound()
        {
            try
            {
                SystemSounds.Exclamation.Play();
            }
            catch (Exception ex)
            {
                LogError("An error occurred at TimerUI in PlayAlarmSound: ", ex);
            }
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
            try
            {
                if (string.IsNullOrWhiteSpace(numDay.Text))
                {
                    numDay.Value = 0;
                }
                else if (string.IsNullOrWhiteSpace(numHour.Text))
                {
                    numHour.Value = 0;
                }
                else if (string.IsNullOrWhiteSpace(numMinute.Text))
                {
                    numMinute.Value = 0;
                }
                else if (string.IsNullOrWhiteSpace(numSecond.Text))
                {
                    numSecond.Value = 0;
                }
                TimerStart();
            }
            catch (Exception ex)
            {
                LogError("An error occurred at TimerUI in blankCheck: ", ex);
            }
        }

        private void PauseTimer()
        {
            timer1.Stop();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            isPaused = true;
        }

        private void ResetTimer()
        {
            timer1.Stop();
            labelTimer.Text = "00:00:00:00";
            showUI();
            btnStart.Enabled = true;
            numDay.Value = 0;
            numHour.Value = 0;
            numMinute.Value = 0;
            numSecond.Value = 0;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseTimer();
        }
    }
}

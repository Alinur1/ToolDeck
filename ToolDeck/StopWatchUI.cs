using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolDeck
{
    public partial class StopWatchUI : UserControl
    {
        private Stopwatch stopwatch = new Stopwatch();
        private TimeSpan lastLapTime = TimeSpan.Zero;
        public StopWatchUI()
        {
            InitializeComponent();
            timer1.Interval = 10;
            lblTime.Text = "00:00:00.00";
        }

        private void StopWatchStartStop()
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
                timer1.Start();
                btnStartStop.Text = "Stop";
            }
            else
            {
                stopwatch.Stop();
                timer1.Stop();
                btnStartStop.Text = "Start";
            }
        }

        private void LapStatus()
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan currentTime = stopwatch.Elapsed;
                TimeSpan lapDuration = currentTime - lastLapTime;
                lastLapTime = currentTime;

                string lapText = $"Lap {lstLaps.Items.Count + 1}: " +
                 currentTime.ToString(@"hh\:mm\:ss\.ff") +
                 $" (+{lapDuration.ToString(@"hh\:mm\:ss\.ff")})";

                lstLaps.Items.Insert(0, lapText);
            }
        }

        private void ResetStopWatch()
        {
            stopwatch.Reset();
            timer1.Stop();
            lblTime.Text = "00:00:00.00";
            lstLaps.Items.Clear();
            lastLapTime = TimeSpan.Zero;
            btnStartStop.Text = "Start/Stop";
        }



        //UI related code

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            StopWatchStartStop();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            LapStatus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            lblTime.Text = ts.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetStopWatch();
        }
    }
}

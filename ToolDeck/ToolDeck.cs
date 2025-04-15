namespace ToolDeck
{
    public partial class ToolDeck : Form
    {

        ClockUI clock = new ClockUI();
        TimerUI timerUI = new TimerUI();
        StopWatchUI stopWatchUI = new StopWatchUI();

        public ToolDeck()
        {
            InitializeComponent();
            addClockUserControl(clock);
        }

        private void addClockUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelClock.Controls.Clear();
            panelClock.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            addClockUserControl(clock);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            addClockUserControl(timerUI);
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            addClockUserControl(stopWatchUI);
        }
    }
}

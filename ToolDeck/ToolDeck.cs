namespace ToolDeck
{
    public partial class ToolDeck : Form
    {

        ClockUI clock = new ClockUI();
        TimerUI timerUI = new TimerUI();
        StopWatchUI stopWatchUI = new StopWatchUI();
        MergePDF mergePDFUI = new MergePDF();

        public ToolDeck()
        {
            InitializeComponent();
            addClockUserControl(clock);
            addPDFToolsUserControl(mergePDFUI);
        }

        private void addClockUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelClock.Controls.Clear();
            panelClock.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addPDFToolsUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelPDFTools.Controls.Clear();
            panelPDFTools.Controls.Add(userControl);
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

        private void btnMergePDF_Click(object sender, EventArgs e)
        {
            addPDFToolsUserControl(mergePDFUI);
        }
    }
}

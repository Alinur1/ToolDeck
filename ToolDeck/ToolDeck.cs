namespace ToolDeck
{
    public partial class ToolDeck : Form
    {
        //Clock
        ClockUI clock = new ClockUI();
        TimerUI timerUI = new TimerUI();
        StopWatchUI stopWatchUI = new StopWatchUI();

        //PDF Tools
        MergePDF mergePDFUI = new MergePDF();
        SplitPDFUI splitPDFUI = new SplitPDFUI();
        CompressPDFUI compressPDFUI = new CompressPDFUI();
        ProtectPDFUI protectPDFUI = new ProtectPDFUI();

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

        private void btnSplitPDF_Click(object sender, EventArgs e)
        {
            addPDFToolsUserControl(splitPDFUI);
        }

        private void btnCompressPDF_Click(object sender, EventArgs e)
        {
            addPDFToolsUserControl(compressPDFUI);
        }

        private void btnProtectPDF_Click(object sender, EventArgs e)
        {
            addPDFToolsUserControl(protectPDFUI);
        }
    }
}

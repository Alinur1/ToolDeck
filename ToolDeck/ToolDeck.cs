namespace ToolDeck
{
    public partial class ToolDeck : Form
    {
        private Button _activeButton;
        //Clock
        ClockUI clock = new ClockUI();
        TimerUI timerUI = new TimerUI();
        StopWatchUI stopWatchUI = new StopWatchUI();

        //PDF Tools
        MergePDF mergePDFUI = new MergePDF();
        SplitPDFUI splitPDFUI = new SplitPDFUI();
        CompressPDFUI compressPDFUI = new CompressPDFUI();
        ProtectPDFUI protectPDFUI = new ProtectPDFUI();
        ReorderPagesUI reorderPagesUI = new ReorderPagesUI();

        public ToolDeck()
        {
            InitializeComponent();
            addClockUserControl(clock);
            addPDFToolsUserControl(mergePDFUI);
        }

        private void HighlightButton(Button selectedButton)
        {
            if (_activeButton != null)
            {
                _activeButton.FlatAppearance.BorderColor = Color.White;
                _activeButton.FlatAppearance.BorderSize = 1;
            }
            _activeButton = selectedButton;
            _activeButton.FlatAppearance.BorderColor = Color.Red;
            _activeButton.FlatAppearance.BorderSize = 2;
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
            HighlightButton((Button)sender);
            addClockUserControl(clock);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            addClockUserControl(timerUI);
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            addClockUserControl(stopWatchUI);
        }

        private void btnMergePDF_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            addPDFToolsUserControl(mergePDFUI);
        }

        private void btnSplitPDF_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            addPDFToolsUserControl(splitPDFUI);
        }

        private void btnCompressPDF_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            addPDFToolsUserControl(compressPDFUI);
        }

        private void btnProtectPDF_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            addPDFToolsUserControl(protectPDFUI);
        }

        private void btnReorderPage_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            addPDFToolsUserControl(reorderPagesUI);
        }

        private void btnSignPDF_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            MessageBox.Show("Still under development. Sorry for the inconvenience.", "ToolDeck - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

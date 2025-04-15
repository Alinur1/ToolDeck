namespace ToolDeck
{
    public partial class ToolDeck : Form
    {

        Clock clock = new Clock();

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
    }
}

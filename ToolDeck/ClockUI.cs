using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ToolDeck.Logger;

namespace ToolDeck
{
    public partial class ClockUI : UserControl
    {
        public ClockUI()
        {
            InitializeComponent();
            ShowRandomAdvice();
        }

        private readonly string[] adviceList = new string[]
        {
            "Please drink some water, stay healthy.",
            "The world is full of chaos; your peace is more important.",
            "You don’t need to have it all figured out today.",
            "Take deep breaths; you’re doing better than you think.",
            "Rest is productive, too.",
            "Say no without feeling guilty to negative people.",
            "Progress is still progress, no matter how small.",
            "Be kind to yourself; you’re growing.",
            "You are a good person. Just believe in GOD and see the miracle.",
            "Sometimes you just have to disconnect to reconnect.",
            "Don't overthink too much. The world can wait. Even slow progress is a progress.",
            "I hope you are having a great day.",
            "You’re allowed to outgrow people, places, and habits.",
            "Small steps every day lead to big changes over time.",
            "It’s okay to ask for help; you don’t have to do it all alone.",
            "Protect your energy like it’s your most valuable asset.",
            "You don’t need a plan; sometimes rest is the plan.",
            "Healing isn’t linear—give yourself grace.",
            "Celebrate how far you’ve come, not just how far you have to go.",
            "Comparison steals joy, focus on your own path.",
            "Trust your timing; it doesn’t have to match anyone else’s.",
            "You are enough, exactly as you are right now.",
        };

        private void ShowRandomAdvice()
        {
            try
            {
                Random rand = new Random();
                int index = rand.Next(adviceList.Length);
                labelAdvice.Text = "Short advice: " + adviceList[index];
            }
            catch(Exception ex)
            {
                LogError("An error occurred at ClockUI in ShowRandomAdvice: ", ex);
            }
        }



        // UI related code

        private void timerClock_Tick(object sender, EventArgs e)
        {
            try
            {
                labelDay.Text = DateTime.Now.ToString("dddd");
                labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
                labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                labelTimeZone.Text = "Time zone: " + DateTime.Now.ToString("UTC:K");
            }
            catch(Exception ex)
            {
                LogError("An error occurred at ClockUI in timerClock_Tick: ", ex);
            }
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            timerClock.Start();
        }
    }
}

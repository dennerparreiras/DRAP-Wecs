using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_29_04_TI_AED_Console
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        public void TimerSplash_Tick(object sender, EventArgs e)
        {
            if (ProgrBarSplash.Value < 100)
            {
                ProgrBarSplash.Value += 20;
            }
            else
            {
                TimerSplash.Enabled = false;
                TimerSplash.Stop();
                this.Visible = false;
                new MainScreen().ShowDialog();
                this.Dispose();
            }
        }
    }
}

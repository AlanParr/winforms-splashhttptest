using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SplashHttpTest
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        delegate void HideSplashCallback();
        delegate void ShowSplashCallback();

        public void HideSplash()
        {
            if (this.InvokeRequired)
            {
                var d = new HideSplashCallback(Hide);
                this.Invoke(d);
            }
            else
            {
                this.Hide();
            }
        }


        public void ShowSplash()
        {
            if (this.InvokeRequired)
            {
                var d = new ShowSplashCallback(Show);
                this.Invoke(d);
            }
            else
            {
                this.Show();
            }
        }
    }
}

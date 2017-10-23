using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class FRMAnzeige : Form
    {
        public FRMAnzeige()
        {
            InitializeComponent();
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.BringToFront();
            this.Focus();
            this.TopMost = true;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Size.Width;
            this.Top = 0;
            Application.DoEvents();

        }

        private void FRMAnzeige_Load(object sender, EventArgs e)
        {
            TimerAnzeige.Enabled = true;
        }

        private void TimerAnzeige_Tick(object sender, EventArgs e)
        {
            double prozent;
            double MomentanStunde = Convert.ToInt32(DateTime.Now.ToString("HH"));
            double MomentanMinute = Convert.ToInt32(DateTime.Now.ToString("mm"));
            double MomentanSekunde = Convert.ToInt32(DateTime.Now.ToString("ss"));
            double MomentanMillisekunde = DateTime.Now.Millisecond;

            Timer.timer = ((Timer.ZielStunde * 3600000) + (Timer.ZielMinute * 60000) + (Timer.ZielSekunde * 1000)) - ((MomentanStunde * 3600000) + (MomentanMinute * 60000) + (MomentanSekunde * 1000) + MomentanMillisekunde);
            if (Timer.timer <= 0)
            {
                this.Close();
            }
            if (Timer.mode == true)
            {

                prozent = (Timer.timer / Timer.timerProzent) * 100;
                LBanzeige.Text = prozent.ToString("00.00") + "%";
            }
            else
            {
                LBanzeige.Text = Timer.timer.ToString();
            }

        }
    }
    }


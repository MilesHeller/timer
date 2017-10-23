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
    public partial class FRMkonfig : Form
    {
        public FRMkonfig()
        {
            InitializeComponent();
            LBtimer.Text = DateTime.Now.Millisecond.ToString();
        }

        

        private void BSFLstart_Click(object sender, EventArgs e)
        {
            
            double MomentanStunde = Convert.ToInt32(DateTime.Now.ToString("HH"));
            double MomentanMinute = Convert.ToInt32(DateTime.Now.ToString("mm"));
            double MomentanSekunde = Convert.ToInt32(DateTime.Now.ToString("ss"));
            double MomentanMillisekunde = DateTime.Now.Millisecond;
            //string[] ZielSplit = TBtime.Text.Split(':');

            //double ZielStunde = Convert.ToInt32(ZielSplit[0]);
            //double ZielMinute = Convert.ToInt32(ZielSplit[1]);
            //double ZielSekunde = Convert.ToInt32(ZielSplit[2]);
            Timer.zielzeit(TBtime.Text);
            Timer.timer = ((Timer.ZielStunde * 3600000) + (Timer.ZielMinute * 60000) + (Timer.ZielSekunde * 1000)) - ((MomentanStunde * 3600000) + (MomentanMinute * 60000) + (MomentanSekunde * 1000) + MomentanMillisekunde);

            
            Timer.timerProzent = Timer.timer;
            Form anzeige = new FRMAnzeige();
            
            if (RBprozentTimer.Checked == true)
            {
                Timer.mode = true;
            }
            else
            {
                Timer.mode = false;
            }
            anzeige.Show();
            //TIMERmain.Enabled = true;

        }


    }
}

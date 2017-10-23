using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public static class Timer 
    {
        public static double timer { get; set; }
        public static double timerProzent { get; set; }
        public static bool mode { get; set; }
        public static double ZielStunde { get; set; }
        public static double ZielMinute { get; set; }
        public static double ZielSekunde { get; set; }
        public static void zielzeit(string eingabe)
        {
            string[] ZielSplit = eingabe.Split(':');

            ZielStunde = Convert.ToInt32(ZielSplit[0]);
            ZielMinute = Convert.ToInt32(ZielSplit[1]);
            ZielSekunde = Convert.ToInt32(ZielSplit[2]);
        }
    }
}

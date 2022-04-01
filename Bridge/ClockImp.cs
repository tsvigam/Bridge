using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ClockImp
    {
        public  TimeSpan GetTime()
        {
            var d = DateTime.Now.TimeOfDay;
            TimeSpan Clock = new TimeSpan(d.Hours, d.Minutes, d.Seconds);
            return Clock;
        }
        public DateTime GetDate()
        {
            var d = DateTime.Now.Date;
            DateTime Date = new DateTime(d.Year, d.Month, d.Day);
            return Date;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public abstract class AbstractionClock
    {
        ClockImp clockImp;

        public AbstractionClock(ClockImp imp)
        {
            clockImp = imp;
        }

        public ClockImp ClockImp
        {
            set { clockImp = value; }
        }

        protected virtual string getTimeS()
        {
            return clockImp.GetTime().ToString();
        }
        public abstract Label getTime();
        public abstract Label getDate();

        protected virtual string getDateS()
        {
            return clockImp.GetDate().ToString();
        }
    }
}

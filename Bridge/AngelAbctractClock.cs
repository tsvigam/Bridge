using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    class AngelAbctractClock : AbstractionClock
    {
        Label angelL;

        public AngelAbctractClock(ClockImp imp)
        : base(imp)
        { angelL = new Label(); }

        protected override string getTimeS()
        {
            return base.getTimeS();
        }
        public override Label getDate()
        {
            angelL.Text = getDateS();
            angelL.Size = new Size(150, 100);
            angelL.ForeColor = Color.Blue;
            angelL.BackColor = Color.White;
            return angelL;
        }
        public override Label getTime()
        {
            angelL.Text = getTimeS();
            angelL.Size = new Size(130, 80);
            angelL.ForeColor = Color.Blue;
            angelL.BackColor = Color.White;
            return angelL;
        }
        protected override string getDateS()
        {
            return base.getDateS();
        }
    }
}


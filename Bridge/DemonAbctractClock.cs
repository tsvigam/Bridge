using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    class DemonAbctractClock : AbstractionClock
    {
        Label demonL;

        public DemonAbctractClock(ClockImp imp)
        : base(imp)
        { demonL = new Label(); }

        public override Label getTime()
        {
            demonL.Text = getTimeS();
            demonL.Size = new Size(150, 100);
            demonL.ForeColor = Color.Red;
            demonL.BackColor = Color.Black;
            return demonL;
        }
        public override Label getDate()
        {
            demonL.Text = getDateS();
            demonL.Size = new Size(150, 100);
            demonL.ForeColor = Color.Red;
            demonL.BackColor = Color.Black;
            return demonL;
        }
    }
}

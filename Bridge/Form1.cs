using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class Form1 : Form
    {
        public TimeSpan Clock;
        TimeSpan d;
        public AbstractionClock clock;

        public Form1()
        {
            
            clock = new DemonAbctractClock(new ClockImp());
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTimer.Text = clock.getTime().Text.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (DateTimer != null) // remove label
            {
                this.Controls.Remove(DateTimer);
                DateTimer = null;
            }
            if (radioButton1.Checked)
            {
                clock = new AngelAbctractClock(new ClockImp());
            }
            else
                clock = new DemonAbctractClock(new ClockImp());
            DateTimer = clock.getTime();
            this.Controls.Add(DateTimer);
        }
    }
}

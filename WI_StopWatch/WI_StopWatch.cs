using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WI_StopWatch
{
    public partial class frmMain : Form
    {
        private IStopWatch stopWatch;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            stopWatch = new SWController(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = stopWatch.GetTime().ToString(@"hh\:mm\:ss");
        }

        public void ChangeText(string newText)
        {
            this.Invoke(new Action(() => 
                {
                    this.label1.Text = newText;
                }));
        }
    }
}

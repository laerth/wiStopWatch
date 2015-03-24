using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WI_StopWatch
{
    public partial class frmMain : Form
    {
        private UI_SWList _swList;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _swList = new UI_SWList();
            _swList.Dock = DockStyle.Fill;
            this.mainContainer.Controls.Add(_swList);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_swList != null)
            {
                _swList.StopAll();
            }
        }
    }
}

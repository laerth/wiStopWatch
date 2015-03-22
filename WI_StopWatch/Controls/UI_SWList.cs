using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WI_StopWatch
{
    public partial class UI_SWList : UserControl
    {
        private List<UserControl> controls;

        public UI_SWList()
        {
            InitializeComponent();

            controls = new List<UserControl>();
        }

        private void AddControl()
        {
            UIStopWatch control = new UIStopWatch(tbCaption.Text);
            control.Dock = DockStyle.Top;
            controls.Add(new UIStopWatch(tbCaption.Text));
            panControls.Controls.Add(control);
            control.Start();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddControl();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}

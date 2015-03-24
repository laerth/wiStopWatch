using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WI_StopWatch
{
    public partial class UI_SWList : UserControl
    {
        private List<UserControl> controls;

        public void StopAll()
        {
            foreach (var c in controls)
            {
                UIStopWatch sw = c as UIStopWatch;
                if (sw != null)
                {
                    sw.Stop();
                }
            }
        }

        public UI_SWList()
        {
            InitializeComponent();
            
            controls = new List<UserControl>();
            panControls.AutoScroll = true;
            Images.ResizeButtonImg(btnAdd, 0.6f);
        }

        private void AddControl()
        {
            UIStopWatch control = new UIStopWatch(string.Empty);
            control.Dock = DockStyle.Top;
            controls.Add(control);
            panControls.Controls.Add(control);
            control.Start();
            control.SetFocus();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddControl();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tbCaption_Enter(object sender, EventArgs e)
        {

        }

        private void tbCaption_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tbCaption_Click(object sender, EventArgs e)
        {

        }
    }
}

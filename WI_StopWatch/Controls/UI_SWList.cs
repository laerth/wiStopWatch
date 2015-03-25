using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WI_StopWatch
{
    public partial class UI_SWList : UserControl
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Form _parentForm;
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

        public UI_SWList(Form parentForm = null)
        {
            InitializeComponent();

            _parentForm = parentForm;
            controls = new List<UserControl>();
            panControls.AutoScroll = true;
            Images.ResizeButtonImg(btnAdd, 0.5f);
            Images.ResizeButtonImg(btnClose, 0.8f);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            _parentForm.Close();
        }

        private void panDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(_parentForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

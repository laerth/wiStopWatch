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
        public event EventHandler ControlAddedOrRemoved;

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
            Common.ResizeButtonImg(btnAdd, 0.5f);
            Common.ResizeButtonImg(btnClose, 0.8f);
            Common.SetHint(btnAdd, "Добавить таймер");
            Common.SetHint(btnClose, "Свернуть в трей");
            Common.SetHint(panDrag, "Переместить");
        }

        public void AddControl()
        {
            _parentForm.SuspendLayout();
            UIStopWatch control = new UIStopWatch(string.Empty);
            control.ControlDeleted += ControlAddedOrRemoved;
            control.Dock = DockStyle.Top;
            controls.Add(control);
            panControls.Controls.Add(control);
            control.SetFocus();
            _parentForm.ResumeLayout();
            if (ControlAddedOrRemoved != null)
            {
                ControlAddedOrRemoved.Invoke(this, null);
            }
        }

        public int GetRealHeight()
        {
            int h = 0;
            foreach (var c in controls)
            {
                UIStopWatch sw = c as UIStopWatch;
                if (sw != null && sw.IsAlive)
                {
                    h += c.Height;
                }
            }

            h += panBorder.Height;
            h += panButtons.Height;

            return h;
        }

        public void FocusFirst()
        {
            foreach (Control c in panControls.Controls)
            {
                UIStopWatch sw = c as UIStopWatch;
                if (sw != null)
                {
                    sw.SetFocus();
                    break;
                }
            }
        }

        public string GetTotalTimeS()
        {
            TimeSpan total = new TimeSpan();
            foreach (var c in controls)
            {
                UIStopWatch sw = c as UIStopWatch;
                if (sw != null && sw.IsAlive)
                {
                    total += sw.GetTime();
                }
            }

            return total.ToString(@"hh\:mm\:ss");
        }

        public int GetTaskCount()
        {
            int count = 0;
            foreach (var c in controls)
            {
                UIStopWatch sw = c as UIStopWatch;
                if (sw != null && sw.IsAlive)
                {
                    count++;
                }
            }

            return count;
        }

        public int GetRunningCount()
        {
            int count = 0;
            foreach (var c in controls)
            {
                UIStopWatch sw = c as UIStopWatch;
                if (sw != null && sw.IsAlive && sw.IsRunning())
                {
                    count++;
                }
            }

            return count;
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
            (_parentForm as frmMain).Minimize();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WI_StopWatch
{
    public partial class frmMain : Form
    {
        private UI_SWList _swList;
        private NotifyIcon _notifyIco;
        private Thread notifyUpdater;

        public frmMain()
        {
            InitializeComponent();
            CreateNotifyIco();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            _swList.FocusFirst(); 
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

        private ContextMenu CreateNotifyMenu()
        {
            ContextMenu menu = new ContextMenu();
            MenuItem mi = menu.MenuItems.Add("Выход");
            mi.Click += mi_Click;
            return menu;
        }

        void mi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateNotify()
        {
            while (true)
            {
                this.Invoke(new Action(() =>
                    {
                        string outstr = string.Format("Задач на выполнении: {0} / {1}\r\n\r\nОбщее время: {2}",
                            _swList.GetRunningCount().ToString(),
                            _swList.GetTaskCount().ToString(),
                            _swList.GetTotalTimeS());
                        _notifyIco.Text = outstr;
                    }));
                Thread.Sleep(250);
            }
        }

        private void CreateNotifyIco()
        {
            _notifyIco = new NotifyIcon();
            _notifyIco.Icon = global::WI_StopWatch.Properties.Resources.stopwatch;
            _notifyIco.Visible = true;
            _notifyIco.Click += _notifyIco_Click;
            _notifyIco.ContextMenu = CreateNotifyMenu();
            _notifyIco.Text = "Секундомер";

            notifyUpdater = new Thread(UpdateNotify);
            notifyUpdater.Start();
        }

        void _notifyIco_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
            this.Activate();
        }

        public void ResizeForm()
        {
            int maxHeight = (int)(0.6 * SystemInformation.VirtualScreen.Height);
            if (_swList != null)
            {
                int realHeight = _swList.GetRealHeight();
                if (realHeight < maxHeight)
                {
                    this.Height = realHeight + 1;
                }
            }
        }

        private void LocateForm()
        {
            int scrW = SystemInformation.VirtualScreen.Width;
            int scrH = SystemInformation.VirtualScreen.Height;
            //int taskBarH = scrH - SystemInformation.WorkingArea.Height;
            int offsetX = (int)(this.Width * 0.1);
            int offsetY = (int)(this.Height * 0.3);
            this.Location = new Point(scrW - this.Width - offsetX, (int)(0.3 * scrH));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _swList = new UI_SWList(this);
            _swList.Dock = DockStyle.Fill;
            _swList.ControlAddedOrRemoved += _swList_AfterControlAdded;
            _swList.AddControl();
            this.mainContainer.Controls.Add(_swList);
            LocateForm();
        }

        void _swList_AfterControlAdded(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notifyUpdater != null)
            {
                notifyUpdater.Abort();
            }
            if (_swList != null)
            {
                _swList.StopAll();
            }
            if (_notifyIco != null)
            {
                _notifyIco.Dispose();
            }
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}

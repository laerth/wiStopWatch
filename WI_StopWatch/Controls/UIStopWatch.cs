using System;
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
    public partial class UIStopWatch : UserControl
    {
        private IStopWatch stopwatch;
        private bool started;

        private void UpdateTimeString(string timeStr)
        {
            this.Invoke(new Action(() =>
            {
                this.laTime.Text = timeStr;
            }));
        }

        public UIStopWatch(string title)
        {
            InitializeComponent();
            this.laCaption.Text = title;
            this.started = false;
            stopwatch = new SWController(UpdateTimeString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _Start();
        }

        private void _Stop()
        {
            stopwatch.Stop();
            started = false;
        }

        private void _Start()
        {
            if (started)
            {
                stopwatch.Stop();
                started = false;
            }
            else
            {
                stopwatch.Start();
                started = true;
            }
        }

        public void Start()
        {
            _Start();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _Stop();
            this.Parent.Controls.Remove(this);
        }
    }
}

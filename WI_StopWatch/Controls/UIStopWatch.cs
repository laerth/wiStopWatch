using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WI_StopWatch
{
    public partial class UIStopWatch : UserControl
    {
        private const float BTN_SCALE = 0.6f;
        private IStopWatch stopwatch;
        private bool started;

        public volatile bool IsAlive;

        private void UpdateTimeString(string timeStr)
        {
            this.Invoke(new Action(() =>
            {
                this.laTime.Text = timeStr;
            }));

        }

        private void ResizeButtonIamges()
        {
            Images.ResizeButtonImg(btnStart, BTN_SCALE);
            Images.ResizeButtonImg(btnRemove, BTN_SCALE);
            Images.ResizeButtonImg(btnReset, BTN_SCALE);
        }

        public UIStopWatch(string title)
        {
            InitializeComponent();
            ResizeButtonIamges();
            IsAlive = true;
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
                _Stop();
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

        public void Stop()
        {
            if (IsAlive)
            {
                _Stop();
            }
        }

        private void Suicide()
        {
            _Stop();
            this.Parent.Controls.Remove(this);
            IsAlive = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Suicide();
        }
    }
}

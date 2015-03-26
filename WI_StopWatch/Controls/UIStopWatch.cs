﻿using System;
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
        private const float BTN_SCALE = 0.4f;
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
            Images.ResizeButtonImg(btnEdit, BTN_SCALE);
        }

        public UIStopWatch(string title)
        {
            InitializeComponent();
            ResizeButtonIamges();
            IsAlive = true;
            this.tbCaption.Text = title;
            this.started = false;
            stopwatch = new SWController(UpdateTimeString);
        }

        public void SetFocus()
        {
            if (!this.tbCaption.Focused)
            {
                this.tbCaption.Focus();
            }
            this.tbCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        public void Blur()
        {
            this.tbCaption.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            _SwapIcons();
        }

        private void _Stop()
        {
            stopwatch.Stop();
            started = false;
        }

        private void _SwapIcons()
        {
            if(started)
            {
                btnStart.BackgroundImage = global::WI_StopWatch.Properties.Resources.pause52;
            }
            else
            {
                btnStart.BackgroundImage = global::WI_StopWatch.Properties.Resources.play128;
            }
            Images.ResizeButtonImg(btnStart, BTN_SCALE);
        }

        public void SwapIcons()
        {
            _SwapIcons();
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

        private void KillSelf()
        {
            _Stop();
            this.Parent.Controls.Remove(this);
            IsAlive = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            KillSelf();
        }

        private void UIStopWatch_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void tbCaption_Leave(object sender, EventArgs e)
        {
            Blur();
        }

        private void tbCaption_Enter(object sender, EventArgs e)
        {
            SetFocus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetFocus();
        }

        private void tbCaption_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    laTime.Focus();
                    break;
            }
        }
    }
}

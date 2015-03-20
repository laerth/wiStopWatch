using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WI_StopWatch
{
    class SWController : IStopWatch
    {
        private StopWatch stopWatch;
        private frmMain frm;
        private Thread updater;

        public SWController(frmMain form)
        {
            frm = form;
            stopWatch = new StopWatch();
        }

        private void UpdateLabel()
        {
            while (true)
            {
                frm.ChangeText(stopWatch.GetTime().ToString(@"hh\:mm\:ss"));
                Thread.Sleep(250);
            }
        }

        public void Start()
        {
            updater = new Thread(UpdateLabel);
            updater.Start();
            stopWatch.Start();
        }

        public void Stop()
        {
            stopWatch.Stop();
        }

        public void Reset()
        {
            stopWatch.Reset();
        }

        public TimeSpan GetTime()
        {
            return stopWatch.GetTime();
        }
    }
}

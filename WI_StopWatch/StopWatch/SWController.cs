using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WI_StopWatch
{
    class SWController : IStopWatch
    {
        private StopWatch stopWatch;
        private frmMain frm;
        private Thread updater;
        private Action<string> setTimeStr;

        public SWController(Action<string> setTimeString)
        {
            setTimeStr = setTimeString;
            stopWatch = new StopWatch();
        }

        private void UpdateLabel()
        {
            try
            {
                while (true)
                {
                    setTimeStr(stopWatch.GetTime().ToString(@"hh\:mm\:ss"));
                    Thread.Sleep(250);
                }
            }
            catch (ThreadAbortException)
            { }
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
            updater.Abort();
        }

        public void Reset()
        {
            stopWatch.Reset();
            setTimeStr("00:00:00");
        }

        public TimeSpan GetTime()
        {
            return stopWatch.GetTime();
        }
    }
}

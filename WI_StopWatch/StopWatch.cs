using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WI_StopWatch
{
    public class StopWatch : IStopWatch
    {
        private bool _stopped = true;
        private DateTime _startTime;
        private DateTime _frozenTime = DateTime.Now;

        private void _Start()
        {
            if (_stopped)
            {
                _startTime = DateTime.Now;
                _stopped = false;
            }
        }

        private void _Stop()
        {
            _frozenTime = DateTime.Now;
            _stopped = true;
        }

        private void _Reset()
        {
            _startTime = DateTime.Now;
        }

        private TimeSpan _GetTime()
        {
            return (_stopped ? _frozenTime : _startTime) - DateTime.Now;
        }

        public void Start()
        {
            _Start();
        }

        public void Stop()
        {
            _Stop();
        }

        public void Reset()
        {
            _Reset();
        }

        public TimeSpan GetTime()
        {
            return _GetTime();
        }
    }
}

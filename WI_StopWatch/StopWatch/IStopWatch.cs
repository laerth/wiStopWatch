using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WI_StopWatch
{
    interface IStopWatch
    {
        /// <summary>
        /// Запустить
        /// </summary>
        void Start();
        /// <summary>
        /// Остановить
        /// </summary>
        void Stop();
        /// <summary>
        /// Перезапуск
        /// </summary>
        void Reset();
        /// <summary>
        /// Текущее время
        /// </summary>
        /// <returns></returns>
        TimeSpan GetTime();
    }
}

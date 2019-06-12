using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler
    {
    internal interface IScheduler
        {
        void ScheduleTask(int hour, int min, double intervalInHour, Action task);
        }
    }

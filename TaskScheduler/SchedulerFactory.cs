using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler
    {
    internal class SchedulerFactory
        {
        private static IScheduler _scheduler = null;
        static SchedulerFactory()
            {
            _scheduler = SchedulerService.Instance;
            }
        public static void IntervalInSeconds(double interval, Action task)
            {
            interval = interval / 3600;
            _scheduler.ScheduleTask(DateTime.Now.Hour, DateTime.Now.Minute, interval, task);
            }
        public static void IntervalInMinutes(double interval, Action task)
            {
            interval = interval / 60;
            _scheduler.ScheduleTask(DateTime.Now.Hour, DateTime.Now.Minute, interval, task);
            }
        public static void IntervalInHours(double interval, Action task)
            {
            _scheduler.ScheduleTask(DateTime.Now.Hour, DateTime.Now.Minute, interval, task);
            }
        }
    }

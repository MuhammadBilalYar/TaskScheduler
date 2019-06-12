using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TaskScheduler
    {
    internal class SchedulerService : IScheduler
        {
        private static readonly IScheduler _instance = new SchedulerService();
        private SchedulerService() { }
        public static IScheduler Instance => _instance;
        public void ScheduleTask(int hour, int min, double intervalInHour, Action task)
            {
            DateTime now = DateTime.Now;
            DateTime firstRun = new DateTime(now.Year, now.Month, now.Day, hour, min, 0, 0);

            TimeSpan timeToGo = firstRun - now;
            if (timeToGo <= TimeSpan.Zero)
                {
                timeToGo = TimeSpan.Zero;
                }

            var timer = new Timer(x =>
            {
                task.Invoke();
            }, null, TimeSpan.Zero, TimeSpan.FromHours(intervalInHour));
            }
        }
    }

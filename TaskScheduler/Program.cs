using System;

namespace TaskScheduler
    {
    class Program
        {
        static void Main(string[] args)
            {
            SchedulerFactory.IntervalInSeconds(15,
            () => {
                Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] IntervalInSeconds");
            });


            SchedulerFactory.IntervalInMinutes(1,
            () => {
                Console.WriteLine($"\t\t\t[{DateTime.Now.ToLongTimeString()}] IntervalInMinutes");
            });
    

            SchedulerFactory.IntervalInHours(1,
            () => {
                Console.WriteLine($"\t\t\t\t\t\t[{DateTime.Now.ToLongTimeString()}] IntervalInHours");
            });
            Console.ReadLine();
            }
        }
    }

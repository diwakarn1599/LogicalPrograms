using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    class StopWatch
    {
        public static void ReadInput()
        {
            StartStopWatch();
        } 

        private static void  StartStopWatch()
        {
            //instance for stop watch
            Stopwatch stopwatch = new Stopwatch();

            //stopwatch start
            stopwatch.Start();

            //thread waiting
            Thread.Sleep(1000);

            //stopwatch stop
            stopwatch.Stop();

            //timespan used to store time intervals
            TimeSpan ts = stopwatch.Elapsed;

            //printing using string interpolation
            Console.WriteLine($"Time Elapsed {ts.Hours} hrs {ts.Minutes} mins {ts.Seconds} secs {ts.Milliseconds} ms");

        }
    }
}

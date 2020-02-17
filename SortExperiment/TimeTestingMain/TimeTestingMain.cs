using System;
using System.Threading;
using System.Diagnostics;

namespace TimeTestingMain
{
    class TimeTestingMain
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Thread.Sleep(5000);
            sw.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", sw.ElapsedMilliseconds);
        }
    }
}

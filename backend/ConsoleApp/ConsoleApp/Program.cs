using System;

namespace ConsoleApp
{
    class Program
    {
        private static int iterator = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Rozpoczynam liczenie.");
            var timer = new System.Timers.Timer(2000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

            while(true) { }
        }

        private static void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine($"Iterator: {iterator}");
            iterator++;
        }
    }
}

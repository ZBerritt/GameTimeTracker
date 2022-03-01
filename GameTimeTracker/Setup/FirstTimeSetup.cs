using System;
using System.IO; 

namespace GameTimeTracker.Setup
{
    internal class FirstTimeSetup
    {
        public static bool isSetup()
        {
            // return File.Exists(Tracker.settings);
            return true;
        }

        public static void execute()
        {
            Console.WriteLine("Executing setup...");
        }
    }
}

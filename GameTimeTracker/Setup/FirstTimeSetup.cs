using System;
using GameTimeTracker.TimeTracking;
using System.IO; 

namespace GameTimeTracker.Setup
{
    internal class FirstTimeSetup
    {
        public static bool isSetup()
        {
            return File.Exists(Tracker.settings);
        }

        public static void execute()
        {
            Console.WriteLine("Executing setup...");
        }
    }
}

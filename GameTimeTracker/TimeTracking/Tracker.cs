using System;
using System.IO;

namespace GameTimeTracker.TimeTracking
{
    internal class Tracker
    {
        public static string settings = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GameTimeTracker", "settings.json");
        DataSheet dataSheet;
         

        public Tracker(DataSheet dataSheet)
        {
            this.dataSheet = dataSheet;
        }

        // Main function to begin tracking time
        public void track()
        {

        }

    }
}

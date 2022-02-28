using System;
using System.Windows.Forms;
using GameTimeTracker.Setup;
using System.Threading.Tasks;
using System.Collections.Generic;
using GameTimeTracker.Model;
using System.ComponentModel;

namespace GameTimeTracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* DataManager.SavePlaytimeData(new BindingList<DailyActivity> { 
                new DailyActivity(DateTime.Now, new Dictionary<string, int>() { { "test", 100 }, { "test2", 14 } }),
                new DailyActivity(DateTime.Now.AddDays(1), new Dictionary<string, int>() { { "test", 0 }, { "test2", 69 } }) });
            if (!FirstTimeSetup.isSetup()) FirstTimeSetup.execute();
            var ds = new DataSheet();
            var tracker = new Tracker(ds);
            var trackingTask = Task.Run(() => tracker.track()); // Tracking function */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

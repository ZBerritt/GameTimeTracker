using System;
using System.Windows.Forms;
using GameTimeTracker.Setup;
using GameTimeTracker.TimeTracking;
using System.Threading.Tasks;

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
            if (!FirstTimeSetup.isSetup()) FirstTimeSetup.execute();
            var ds = new DataSheet();
            var tracker = new Tracker(ds);
            var trackingTask = Task.Run(() => tracker.track()); // Tracking function
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

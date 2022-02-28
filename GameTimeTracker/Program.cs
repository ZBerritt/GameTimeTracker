using System;
using System.Diagnostics;
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
            /* var data = new BindingList<DailyActivity> {
                new DailyActivity(DateTime.Now, new Dictionary<string, int>() { { "test", 100 }, { "test2", 14 } }),
                new DailyActivity(DateTime.Now.AddDays(1), new Dictionary<string, int>() { { "test", 0 }, { "test2", 69 } }) };
            DataManager.SavePlaytimeData(data); */
            if (!FirstTimeSetup.isSetup()) FirstTimeSetup.execute();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

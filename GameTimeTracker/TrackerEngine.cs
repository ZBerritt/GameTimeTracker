using GameTimeTracker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTimeTracker
{
    internal class TrackerEngine
    {
        static TrackerEngine instance;
        BindingList<DailyActivity> dailyActivity;

        public TrackerEngine()
        {
            if (instance != null) throw new Exception("Tracker engine instance already created");
            dailyActivity = DataManager.LoadPlaytimeData();
            instance = this;
        }
    }
}

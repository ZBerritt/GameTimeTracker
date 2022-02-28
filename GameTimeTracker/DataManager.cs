using System;
using System.ComponentModel;
using System.IO;
using GameTimeTracker.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GameTimeTracker
{
    
    internal class DataManager
    {
        static string playtimeDataLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GameTimeTracker", "activity.json");

        public static void SavePlaytimeData(BindingList<DailyActivity> activity)
        {
            JArray json = new JArray();
            foreach (DailyActivity activityItem in activity)
            {
                json.Add(activityItem.ToJson()); 
            }
            string jsonData = json.ToString();
            if (!File.Exists(playtimeDataLocation)) File.Create(playtimeDataLocation);
            File.WriteAllText(playtimeDataLocation, jsonData);
        }
    }
}

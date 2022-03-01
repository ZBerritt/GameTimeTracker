using System;
using System.Collections.Generic;
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
            string jsonData = JsonConvert.SerializeObject(json, Formatting.None);
            if (!File.Exists(playtimeDataLocation)) File.Create(playtimeDataLocation);
            File.WriteAllText(playtimeDataLocation, jsonData);
        }

        public static BindingList<DailyActivity> LoadPlaytimeData()
        {
            BindingList<DailyActivity> res = new BindingList<DailyActivity>();
            if (!File.Exists(playtimeDataLocation)) return res;
            var data = File.ReadAllText(playtimeDataLocation);
            var parsedData = JsonConvert.DeserializeObject<JArray>(data);
            foreach(JObject day in parsedData) 
            {
                DateTime date = DateTime.Parse((string)day.GetValue("date"));
                JArray playtimeJson = (JArray)day.GetValue("game_playtime");
                Dictionary<string, int> playtime = new Dictionary<string, int>();
               foreach(JObject gamePlaytime in playtimeJson)
                {
                    playtime.Add((string)gamePlaytime.GetValue("game"), int.Parse((string)gamePlaytime.GetValue("playtime")));
                }

               DailyActivity activity = new DailyActivity(date, playtime);
               res.Add(activity);
            }
            
            return res;
        }
    }
}

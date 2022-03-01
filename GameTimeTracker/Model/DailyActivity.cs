using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameTimeTracker.Model
{
    internal class DailyActivity : IDailyActivity
    {
        public DateTime Date { get; }
        public Dictionary<string, int> Playtime { get; }

        public DailyActivity(DateTime date, Dictionary<string, int> playtime)
        {
            Date = date;
            Playtime = playtime;
        }

        public JObject ToJson()
        {
            JObject json = new JObject();
            json.Add("date", Date.ToString("MM/dd/yyyy"));

            JArray gameArray = new JArray();
            foreach (var item in Playtime)
            {
                JObject gameObject = new JObject();
                gameObject.Add("game", item.Key);
                gameObject.Add("playtime", item.Value);
                gameArray.Add(gameObject);
            }

            json.Add("game_playtime", gameArray);
            return json;
        }

        public int TotalPlaytime()
        {
            return Playtime.Values.Sum();
        }
    }
}

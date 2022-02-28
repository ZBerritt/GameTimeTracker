using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTimeTracker.Model
{
    internal class DailyActivity : IDailyActivity
    {
        public DateTime Date { get; }
        public Dictionary<string, int> Playtime { get; }

        public string Serialize()
        {
            JObject json = new JObject();
            json.Add("date", Date.ToString());
            
            JArray gameArray = new JArray();
            foreach (var item in Playtime)
            {
                JObject gameObject = new JObject();
                gameObject.Add("game", item.Key);
                gameObject.Add("playtime", item.Value);
                gameArray.Add(gameObject);
            }

            return json.ToString();
        }

        public int TotalPlaytime()
        {
            return Playtime.Values.Sum();
        }
    }
}

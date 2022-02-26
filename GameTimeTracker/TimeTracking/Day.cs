using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTimeTracker.TimeTracking
{
    internal class Day
    {
        DateTime date;
        Dictionary<string, int> playtime;

        // Builds when a new day is created
        public Day(string[] gameList)
        {
            playtime = new Dictionary<string, int>();
            foreach (var game in gameList)
            {
                if (game == "placeholder") continue;
                playtime.Add(game, 0);
            }
        }

        // Builds when data is retrieved from csv
        public Day(DateTime date, Dictionary<string, int> playtime)
        {
            this.date = date;
            this.playtime = playtime;
        }

        public bool isToday()
        {
            return date.Date == DateTime.Today;
        }

        public void addMinute(string game)
        {
            if (playtime.ContainsKey(game))
                playtime[game] += 1;
        }
    }
}

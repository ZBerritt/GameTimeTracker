using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace GameTimeTracker.TimeTracking
{
    internal class DataSheet
    {
        
        public static string data = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GameTimeTracker", "data.csv");


        // Parsed data
        List<Day> dayList = new List<Day>();

        public DataSheet()
        {
            string csvData = File.OpenText(data).ReadToEnd();
            string[] rows = csvData.Split('\n').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string[] gameList = rows[0].Split(',').Skip(1).ToArray(); // Removes placeholder
            string[] days = rows.Skip(1).Where(x => !string.IsNullOrEmpty(x)).ToArray(); // Removes game titles
            foreach (string day in days)
            {
                string[] formattedDay = day.Split(',');
                string date = formattedDay[0];
                var dateTime = DateTime.Parse(date, CultureInfo.CurrentCulture);
                string[] times = formattedDay.Skip(1).ToArray();
                Dictionary<string, int> playtime = new Dictionary<string, int>();
                for (int i = 0; i < gameList.Length; i++)
                {
                    if (times.Length >= i)
                    {
                        playtime[gameList[i]] = 0;
                    }  else
                    {
                        playtime[gameList[i]] = int.Parse(times[i]);
                    }
                    
                }

                var dayClass = new Day(dateTime, playtime);
                dayList.Add(dayClass);
            }

        }
    }
}

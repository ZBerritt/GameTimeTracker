using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace GameTimeTracker.Model
{
    /// <summary>
    /// Represents the game activity done in a single day
    /// </summary>
    internal interface IDailyActivity
    {
        /// <summary>
        /// The day associated with the playtime
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// A key value pair for each game and the amount of minutes played
        /// </summary>
        Dictionary<string, int> Playtime { get; }

        /// <summary>
        /// The total playtime in minutes on that given day
        /// </summary>
        int TotalPlaytime();

        /// <summary>
        /// Serializes the data into JSON format 
        /// </summary>
        JObject ToJson();
    }
}

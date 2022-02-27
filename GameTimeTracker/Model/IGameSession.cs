using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTimeTracker.Model
{
    internal interface IGameSession
    {
        /// <summary>
        /// The game being played during the session
        /// </summary>
        Game game { get; }

        /// <summary>
        /// The start time of the session
        /// </summary>
        DateTime StartTime { get; }

        /// <summary>
        /// The end time of the session, only has value if the game session has ended
        /// </summary>
        DateTime EndTime { get; }

        /// <summary>
        /// Function to get the total elapsed time of the session
        /// </summary>
        TimeSpan GetElapsedTime();
    }
}

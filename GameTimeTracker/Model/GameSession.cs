using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTimeTracker.Model
{
    internal class GameSession : IGameSession
    {
        /// <summary>
        /// <see cref="IGameSession.Game"/>
        /// </summary>
        public Game game { get; }

        /// <summary>
        /// <see cref="IGameSession.StartTime"/>
        /// </summary>
        public DateTime StartTime { get; }

        /// <summary>
        /// <see cref="IGameSession.EndTime"/>
        /// </summary>
        public DateTime EndTime { get; }

    

        public GameSession(DateTime startTime, DateTime endTime, Game game)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.game = game;
        }

        /// <summary>
        /// <see cref="IGameSession.GetElapsedTime"/>
        /// </summary>
        public TimeSpan GetElapsedTime()
        {
            return EndTime.Subtract(StartTime);
        }


    }
}

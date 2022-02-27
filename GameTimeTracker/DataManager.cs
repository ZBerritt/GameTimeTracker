using System;
using System.ComponentModel;
using GameTimeTracker.Model;
using Newtonsoft.Json.Linq;


namespace GameTimeTracker
{
    internal class DataManager
    {

    public static string SerializeSessions(BindingList<GameSession> data)
        {
            JArray json = new JArray();
            foreach (GameSession session in data)
            {
                JObject serializedSession = new JObject();
                string start = session.StartTime.ToString();
                string end = session.EndTime.ToString();
                string game = session.game;
                serializedSession.Add("game", game);
                serializedSession.Add("start", start);
                serializedSession.Add("end", end);
                json.Add(serializedSession);
            }
            string res = json.ToString();
            Console.WriteLine(res);
            return res;
        }
        public static BindingList<GameSession> DeserializeSessions(string data)
        {
            BindingList<GameSession> gameSessions = new BindingList<GameSession>();
            JArray json = JArray.Parse(data);
            foreach (JObject session in json)
            {
                string game = (string)session.GetValue("game");

                string start = (string)session.GetValue("start");
                DateTime startTime = DateTime.Parse(start);

                string end = (string)session.GetValue("end");
                DateTime endTime = DateTime.Parse(end);

                GameSession gameSession = new GameSession(startTime, endTime, game);
                gameSessions.Add(gameSession);
            }

            return gameSessions;
        }
    }
        
}

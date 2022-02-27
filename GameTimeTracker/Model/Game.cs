using System.Diagnostics;

namespace GameTimeTracker.Model
{
    internal class Game
    {
        public string name { get; }
        public string processName { get; }
        public string windowName { get; }
        public string executable { get; }


        public Game(string name, string processName, string windowName, string executable)
        {
            this.processName = processName;
            this.name = name;
            this.windowName = windowName;
            this.executable = executable;
        }

        // Returns true if program is running
        public bool isRunning()
        {
            Process[] activeProcesses = Process.GetProcesses();
            foreach (Process prc in activeProcesses)
            {
                if (prc.ProcessName == processName) return true;
                if (!string.IsNullOrEmpty(prc.MainWindowTitle) && prc.MainWindowTitle == windowName) return true;
                if (prc.MainModule.FileName == executable) return true;
            }
            return false;
        }
    }
}

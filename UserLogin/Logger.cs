using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UserLogin
{
    public static class Logger
    {
        static private readonly string logFileName = "logs.txt";
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" +
                                    LoginValidator.currentUser.Username + ";" +
                                    LoginValidator.currentUser.Role + ";" +
                                    activity;
            currentSessionActivities.Add(activityLine);

            File.AppendAllText(logFileName, activityLine + "\n");
        }

        static public IEnumerable<string> GetLogs()
        {
            if (!File.Exists(logFileName))
            {
                return null;
            }

            List<string> logsFromFile = new List<string>();

            foreach (string line in File.ReadLines(logFileName))
            {
                logsFromFile.Add(line);
            }
            return logsFromFile;
        }

        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            return from activity in currentSessionActivities
                   where activity.Contains(filter)
                   select activity;
        }

        static public void CreateCertificate(string certificate, string pathToFile)
        {
            File.WriteAllText(pathToFile, certificate);
        }
    }
}

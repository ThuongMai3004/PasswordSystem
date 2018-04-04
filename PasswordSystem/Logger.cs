using PasswordSystem.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSystem
{
    public static class Logger
    {
        public static void Log(string msg, int isNewLine = 0)
        {
            string logTime = null;
            if (isNewLine == 0)
            {
                string thisDay = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss");
                logTime = "[" + thisDay + "]" + "  " + msg;
            }
            else if (isNewLine == 1)
            {
                string thisDay = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss");
                logTime = "\n[" + thisDay + "]" + "  " + msg;
            }
            else if (isNewLine == 2)
            {
                string thisDay = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss");
                logTime = "\n---------[" + msg + "]---------";
            }
            else if (isNewLine == 3)
            {
                string thisDay = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss");
                logTime = "-----------------------" +
                          "\n-----------------------\n[" + thisDay + "]" + "  " + msg;
            }
            else if (isNewLine == 4)
            {
                string thisDay = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss");
                logTime = "\n\n=====================================================================\n" +
                    "=====================================================================\n" +
                    "==================NEW SECTION [" + thisDay + "]=================\n" +
                    "=====================================================================\n" +
                    "=====================================================================\n";
            }
            ReadWriteFiles.WriteToFile(Model.logFileName, logTime);
        }

        public static void Log(string user, string msg)
        {
            string thisDay = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss");
            string logUser = "\n\n-------------- USER: " + user + " --------------";
            ReadWriteFiles.WriteToFile(Model.logFileName, logUser);
            string logTime = "[" + thisDay + "]" + "  " + msg;
            ReadWriteFiles.WriteToFile(Model.logFileName, logTime);
        }

        /*private static void WriteToFile(string msg)
        {
            if (!File.Exists(logFileName))
            {
                using (StreamWriter sw = File.CreateText(logFileName))
                {
                    sw.WriteLine(msg);
                }
            }
            else
            {
                using (StreamWriter file = new StreamWriter(logFileName, true))
                {
                    file.WriteLine(msg);
                }
            }
        }*/

        public static void DisplayLogFile()
        {
            ReadWriteFiles.DisplayFile(Model.logFileName);
        }
        public static void CleanLogFile(bool isClean = false)
        {
            if (!isClean)
                Log("", 4);
            //else
                //File.WriteAllText(logFileName, String.Empty);
        }
    }
}

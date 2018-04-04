using PasswordSystem.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswordSystem
{
    public static class ReadWriteFiles
    {
        public static void WriteToFile(string fileName, string msg)
        {
            string path = Directory.GetCurrentDirectory() + fileName;
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(msg);
                }
            }
            else
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(msg);
                }
            }
        }

        /**Read from a file and return the list of string*/
        public static List<string> ReadFromFile(string fileName)
        {
            string path = Directory.GetCurrentDirectory() + fileName;
            List<string> lines = new List<string>();
            if (File.Exists(path))
            {
                using (StreamReader file = File.OpenText(path))
                {
                    string s = "";
                    while((s = file.ReadLine()) != null)
                    {
                        lines.Add(s);
                    }
                }
            }
            return lines;
        }

        public static void DisplayFile(string fileName)
        {
            string path = Directory.GetCurrentDirectory() + fileName;
            if (File.Exists(path))
                Process.Start("notepad.exe", path);
            else
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
                Process.Start("notepad.exe", path);
            }
        }

        /**Read the file then add to Model.Accounts list*/
        public static void ReadAccountFile(string chooseAccountFileName)
        {
            string countSavedUser = "";
            Model.EraseAccounts();
            List<String> lines = ReadWriteFiles.ReadFromFile(chooseAccountFileName);
            if (lines.Count != 0)
            {
                Console.WriteLine(lines);
                foreach (string aLine in lines)
                {
                    string _user = aLine.Split(',').First();
                    string _pass = aLine.Split(',').ElementAt(1);
                    string _key = aLine.Split(',').Last();
                    Model.AddToAccounts(_user, _pass);
                    countSavedUser = _user;
                }
                Model.Count = Convert.ToInt32(Regex.Match(countSavedUser, @"\d+").Value) + 1;
            }
        }

        /**Open the form if it's not there, or focus the form*/
        public static void DisplayForm<T>(ref T form) where T : Form, new()
        {
            if (form == null || form.Text == "")
            {
                form = new T();
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else if (Model.CheckFormOpen(form))
            {
                form.WindowState = FormWindowState.Normal;
                form.Dock = DockStyle.Fill;
                form.Show();
                form.Focus();
            }
        }
    }
}

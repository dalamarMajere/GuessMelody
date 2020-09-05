using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection.Emit;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Controller
    {
        static private List<string> musicList = new List<string>();
        static private int gameDuration;
        static private int melodyDuration;
        static private bool randomStart;
        static private string lastFolder = "";
        static private bool allDirectories;
        static private int timeToAns;
        static private string controlKey = "AP";

        static public void writeSettings()
        {
            RegistryKey key = null;
            try
            {
                key = Registry.CurrentUser.CreateSubKey(keyName);
                if (key == null) return;

                key.SetValue("gameDuration", gameDuration);
                key.SetValue("melodyDuration", melodyDuration);
                key.SetValue("randomStart", randomStart);
                key.SetValue("lastFolder", lastFolder);
                key.SetValue("allDirectories", allDirectories);
                key.SetValue("timeToAnswer", timeToAns);
                key.SetValue("controlKey", controlKey);
            }
            finally { if (key != null) key.Close(); }
        }

        static public void readSettings()
        {
            RegistryKey key = null;
            try
            {
                key = Registry.CurrentUser.OpenSubKey(keyName);
                if (key == null) return;

                gameDuration = Convert.ToInt32(key.GetValue("gameDuration"));
                melodyDuration = Convert.ToInt32(key.GetValue("melodyDuration"));
                randomStart = Convert.ToBoolean(key.GetValue("randomStart"));
                lastFolder = (string)key.GetValue("lastFolder");
                allDirectories = Convert.ToBoolean(key.GetValue("allDirectories"));
                timeToAns = Convert.ToInt32(key.GetValue("timeToAnswer"));
                controlKey = (string)(key.GetValue("controlKey"));
                if (controlKey is null) controlKey = "AP";
            }
            finally { if (key != null) key.Close(); }
        }

        static private string keyName = "Software\\DalamarProd\\GuessMelody";
        static private Random rnd = new Random();

        static public void setGameDuration(int gd) { gameDuration = gd; }
        static public void setMelodyDuration(int md) { melodyDuration = md; }
        static public void setLastFolder(string lf) { lastFolder = lf; }
        static public void setAllDirectories(bool ad) { allDirectories = ad; }
        static public void setRandomStart(bool rs) { randomStart = rs; }
        static public void setTimeToAns(int time) { timeToAns = time; }
        static public void setControlKey(string ck) { controlKey = ck; }
        static public void setMusic(string[] list)
        {
            musicList.Clear();
            musicList.AddRange(list);
        }

        static public string getMusic()
        {
            if (musicList.Count != 0)
            {
                int ind = rnd.Next(0, musicList.Count);
                string tmp = musicList[ind];
                musicList.RemoveAt(ind);
                return tmp;
            }
            return "";
        }
        static public List<string> getMusicList() { return musicList; }

        static public int getGameDuration() { return gameDuration; }
        static public int getMelodyDuration() { return melodyDuration; }
        static public string getLastFolder() { return lastFolder; }
        static public bool getAllDirectories() { return allDirectories; }
        static public bool getRandomStart() { return randomStart; }
        static public int getMelodyAmount() { return musicList.Count(); }
        static public int getTimeToAns() { return timeToAns; }
        static public char getControlKey(int ind)
        {
            try
            {
                if (ind < 2) return controlKey.ElementAt<char>(ind);
                else return 'A';
            }
            finally
            { }
            return 'A';
        }
    }
}

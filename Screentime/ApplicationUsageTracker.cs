using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Screentime
{
    internal class ApplicationUsageTracker
    {
        //Define private data structures & variables
        private Dictionary<string, TimeSpan> appUsageTimes;
        private string currentAppName;
        private DateTime lastUpdateTime;

        //Function to retrieve handle to the window currently in foreground
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        //Function to retrieve the title of a window and copy the title into a buffer
        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        //Constructor
        public ApplicationUsageTracker()
        {
            appUsageTimes = new Dictionary<string, TimeSpan>();
            lastUpdateTime = DateTime.Now;
            currentAppName = GetActiveWindowTitle();
        }

        //Function to update application usage times
        public void UpdateUsageTimes()
        {
            string activeAppName = GetActiveWindowTitle();
            DateTime now = DateTime.Now;

            if (!string.IsNullOrEmpty(currentAppName))
            {
                if (!appUsageTimes.ContainsKey(currentAppName)) //Checks if dictionary 'appUsageTimes' contains a key 'currentAppName'
                {
                    appUsageTimes[currentAppName] = TimeSpan.Zero; //The two 'if' statements ensure the key 'currentAppName' doesnt already exist. Sets value associated with key 'currentAppName' in the 'appUsageTimes' dictionary to 0 seconds
                }
                appUsageTimes[currentAppName] += now - lastUpdateTime; //Updates the value associated with key 'currentAppName' by adding the difference between now and last update time to the value
            }
            currentAppName = activeAppName;
            lastUpdateTime = now;
        }
        
        //Function to retrieve the activeWindowTitle (if one exists), push it to a buffer, and return the buffer as a string
        public string GetActiveWindowTitle()
        {
            const int maxChars = 256;
            IntPtr handle = GetForegroundWindow();
            StringBuilder Buff = new StringBuilder(maxChars);
            if (GetWindowText(handle, Buff, maxChars) > 0) //If there exists a window title to retrieve then ...
            {
                return Buff.ToString();
            }
            return null;
        }

        //Getter function for 'appUsageTimes' dictionary - Necessary to allow access to 'appUsageTimes' dictionary from outside of this class
        public Dictionary<string, TimeSpan> GetUsageTimes()
        {
            return appUsageTimes;
        }
        
    }
}

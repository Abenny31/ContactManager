using System;
using System.Configuration;

namespace ContactManager
{
    public class Global
    {
        public static string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string JsonLocation = System.IO.Path.Combine(appDataFolderPath, "contact", "contactlist.json");
        public static string ConnStringDB = ConfigurationManager.AppSettings["ConnStringDB"];
        public static bool UseDB = bool.Parse(ConfigurationManager.AppSettings["UseDB"]);
        public static string user = ConfigurationManager.AppSettings["user"];
        public static string pass = ConfigurationManager.AppSettings["pass"];
    }
}

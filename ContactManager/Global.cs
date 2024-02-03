using System.Configuration;

namespace ContactManager
{
    public class Global
    {
        public static string JsonLocation = "C:\\Users\\Public\\contact\\contactlist.json";
        public static string ConnStringDB = ConfigurationManager.AppSettings["ConnStringDB"];
        public static bool UseDB = bool.Parse(ConfigurationManager.AppSettings["UseDB"]);
        public static string user = ConfigurationManager.AppSettings["user"];
        public static string pass = ConfigurationManager.AppSettings["pass"];
    }
}

using System.Configuration;

namespace ContactManager
{
    public class Global
    {
        public static string JsonLocation = ConfigurationManager.AppSettings["JsonLocation"];
        public static string ConnStringDB = ConfigurationManager.AppSettings["ConnStringDB"];
        public static string UserLocation = ConfigurationManager.AppSettings["UserLocation"];
        public static bool UseDB = bool.Parse(ConfigurationManager.AppSettings["UseDB"]);
    }
}

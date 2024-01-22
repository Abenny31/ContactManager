using System.Configuration;

namespace ContactManager
{
    internal class Global
    {
        public string JsonLocation = ConfigurationManager.AppSettings["JsonLocation"];
        public string ConnStringDB = ConfigurationManager.AppSettings["ConnStringDB"];
        public string UserLocation = ConfigurationManager.AppSettings["UserLocation"];
        public bool UseDB = bool.Parse(ConfigurationManager.AppSettings["UseDB"]);
    }
}

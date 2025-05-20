using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace sslcheker.Data
{
    internal class PConfig
    {
        public static int ERROR { get; set; }
        public static int WARNING { get; set; }
        public static int PERIODICALCHECK { get; set; }
        public static int PERIODICALTIME { get; set; }
        public static int EMAILENABLE { get; set; }
        public static string SMTPHOST { get; set; }
        public static int SMTPPORT { get; set; }
        public static string SMTPUSER { get; set; }
        public static string SMTPPASSWORD { get; set; }
        public static int SMTPSSL { get; set; }
        public static int SMTPAUTENTIFICATE { get; set; }
        public static string EMAILFROM { get; set; }
        public static string EMAILTO { get; set; }
        public static int ALERTONCANNOTCONNECT { get; set; }

    }
}

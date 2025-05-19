using sslcheker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace sslcheker.Operations
{
    internal class Operations2
    {

        public static bool isPeriodicalCheckEnabled() {
            if (PConfig.PERIODICALCHECK == 1)
            {
                return true;
            }
            return false;
        }

        public static void sendEmai(string message, string subject)
        {
            try {
                 SmtpClient smtpClient = new SmtpClient(PConfig.SMTPHOST)
                 {
                    Port = PConfig.SMTPPORT,
                    Credentials = new NetworkCredential("username", "password"),
                    EnableSsl = true,
                 };
                 smtpClient.Send(PConfig.EMAILTO, PConfig.EMAILFROM, subject, message);

            } catch { 
            
            }
        }


    }
}

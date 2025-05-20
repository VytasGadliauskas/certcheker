using Microsoft.Win32;
using sslcheker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace sslcheker.Control
{
    internal class RegistryOperations
    {

        public static void Write() 
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\VG\certcheker"))
            {
                key.SetValue("ERROR", PConfig.ERROR);
                key.SetValue("WARNING",PConfig.WARNING);
                key.SetValue("PERIODICALCHECK", PConfig.PERIODICALCHECK);
                key.SetValue("PERIODICALTIME", PConfig.PERIODICALTIME);
                key.SetValue("EMAILENABLE", PConfig.EMAILENABLE);
                key.SetValue("SMTPHOST", PConfig.SMTPHOST);
                key.SetValue("SMTPPORT", PConfig.SMTPPORT);
                key.SetValue("SMTPUSER", PConfig.SMTPUSER);
                key.SetValue("SMTPPASSWORD", PConfig.SMTPPASSWORD);
                key.SetValue("SMTPAUTENTIFICATE", PConfig.SMTPAUTENTIFICATE);
                key.SetValue("SMTPSSL", PConfig.SMTPSSL);
                key.SetValue("EMAILFROM", PConfig.EMAILFROM);
                key.SetValue("EMAILTO", PConfig.EMAILTO);
                key.SetValue("ALERTONCANNOTCONNECT", PConfig.ALERTONCANNOTCONNECT);
                key.Close();
            }
        }

        public static void Read()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\VG\certcheker"))
            {
                if (key.GetValueNames().Contains("ERROR"))
                {
                    PConfig.ERROR = Int32.Parse(key.GetValue("ERROR").ToString());
                }
                else {
                    key.SetValue("ERROR", 1);
                    PConfig.ERROR = 1;
                }

                if (key.GetValueNames().Contains("WARNING"))
                {
                    PConfig.WARNING = Int32.Parse(key.GetValue("WARNING").ToString());
                }
                else
                {
                    key.SetValue("WARNING", 10);
                    PConfig.WARNING = 1;
                }

                if (key.GetValueNames().Contains("PERIODICALCHECK"))
                {
                    PConfig.PERIODICALCHECK = Int32.Parse(key.GetValue("PERIODICALCHECK").ToString());
                }
                else
                {
                    key.SetValue("PERIODICALCHECK", 0);
                    PConfig.PERIODICALCHECK = 0;
                }

                if (key.GetValueNames().Contains("PERIODICALTIME"))
                {
                    PConfig.PERIODICALTIME = Int32.Parse(key.GetValue("PERIODICALTIME").ToString());
                }
                else
                {
                    key.SetValue("PERIODICALTIME", 24);
                    PConfig.PERIODICALTIME = 24;
                }

                if (key.GetValueNames().Contains("EMAILENABLE"))
                {
                    PConfig.EMAILENABLE = Int32.Parse(key.GetValue("EMAILENABLE").ToString());
                }
                else
                {
                    key.SetValue("EMAILENABLE", 0);
                    PConfig.EMAILENABLE = 0;
                }

                if (key.GetValueNames().Contains("SMTPHOST"))
                {
                    PConfig.SMTPHOST = key.GetValue("SMTPHOST").ToString();
                }
                else
                {
                    key.SetValue("SMTPHOST", "");
                    PConfig.SMTPHOST = "";
                }

                if (key.GetValueNames().Contains("SMTPPORT"))
                {
                    PConfig.SMTPPORT = Int32.Parse(key.GetValue("SMTPPORT").ToString());
                }
                else
                {
                    key.SetValue("SMTPPORT", 25);
                    PConfig.SMTPPORT = 25;
                }


                if (key.GetValueNames().Contains("SMTPUSER"))
                {
                    PConfig.SMTPUSER = key.GetValue("SMTPUSER").ToString();
                }
                else
                {
                    key.SetValue("SMTPUSER", "");
                    PConfig.SMTPUSER = "";
                }


                if (key.GetValueNames().Contains("SMTPPASSWORD"))
                {
                    PConfig.SMTPPASSWORD = key.GetValue("SMTPPASSWORD").ToString();
                }
                else
                {
                    key.SetValue("SMTPPASSWORD", "");
                    PConfig.SMTPPASSWORD = "";
                }


                if (key.GetValueNames().Contains("SMTPAUTENTIFICATE"))
                {
                    PConfig.SMTPAUTENTIFICATE = Int32.Parse(key.GetValue("SMTPAUTENTIFICATE").ToString());
                }
                else
                {
                    key.SetValue("SMTPAUTENTIFICATE", 0);
                    PConfig.SMTPAUTENTIFICATE = 0;
                }


                if (key.GetValueNames().Contains("SMTPSSL"))
                {
                    PConfig.SMTPSSL = Int32.Parse(key.GetValue("SMTPSSL").ToString());
                }
                else
                {
                    key.SetValue("SMTPSSL", 0);
                    PConfig.SMTPSSL = 0;
                }

                if (key.GetValueNames().Contains("EMAILFROM"))
                {
                    PConfig.EMAILFROM = key.GetValue("EMAILFROM").ToString();
                }
                else
                {
                    key.SetValue("EMAILFROM", "");
                    PConfig.EMAILFROM = "";
                }

                if (key.GetValueNames().Contains("EMAILTO"))
                {
                    PConfig.EMAILTO = key.GetValue("EMAILTO").ToString();
                }
                else
                {
                    key.SetValue("EMAILTO", "");
                    PConfig.EMAILTO = "";
                }

                if (key.GetValueNames().Contains("ALERTONCANNOTCONNECT"))
                {
                    PConfig.ALERTONCANNOTCONNECT = Int32.Parse(key.GetValue("ALERTONCANNOTCONNECT").ToString());
                }
                else
                {
                    key.SetValue("ALERTONCANNOTCONNECT", 0);
                    PConfig.ALERTONCANNOTCONNECT = 0;
                }

            }
        }
    }

}

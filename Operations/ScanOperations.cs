using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sslcheker.Operations
{
    internal class ScanOperations
    {
        public static bool IsPortOpen(string host, int port, int timeoutsec)
        {
            TimeSpan timeout = TimeSpan.FromSeconds(timeoutsec);
            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect(host, port, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(timeout);
                    client.EndConnect(result);
                    return success;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool validateIpOctet(string str) 
        {
            try
            {
                if (Int32.Parse(str) < 255 || Int32.Parse(str) > 0) return true;
            } catch 
            {
                return false; 
            }
            return false;
        }

        public static bool validateTextLenth(string str) 
        {
            if (str.Length >= 3) return true;
            return false;
        }

        public static string removeNotNumbers(string str)
        {
           return Regex.Replace(str, "[^0-9]", "");
        }

        public static string resolveIp(string ip) 
        {
            try
            {
                IPAddress address = IPAddress.Parse(ip);
                IPHostEntry host = Dns.GetHostEntry(address);
                return  host.HostName;
            }
            catch
            {
                return ip;
            }
        }
    }
}

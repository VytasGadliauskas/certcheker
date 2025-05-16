using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sslcheker.Data
{
    internal class ClassHost
    {
        public string hostname { get; set; }    
        public int port { get; set; } 
        public string CN { get; set; }
        public int expires_in_days { get; set; }
        public string valid_from { get; set; }
        public string valid_to { get; set; }
        public string last_check { get; set; }
    }
}

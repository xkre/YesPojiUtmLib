using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesPojiUtmLib.Models
{ 
    public class YesSessionData
    {
        public double Sent { get; set; }
        public double Received { get; set; }
        public TimeSpan Time { get; set; }
    }
}

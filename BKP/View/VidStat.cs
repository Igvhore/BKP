using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    class VidStat
    {
        public VidStat() { }
        public VidStat(string p_name, string p_value, string p_date)
        {
            parameter_name = p_name;
            parameter_value = p_value;
            parameter_date = p_date;
        }
        public string parameter_name { get; set; }
        public string parameter_value { get; set; }
        public string parameter_date { get; set; }
    }
}

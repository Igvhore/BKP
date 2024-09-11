using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class SubInfo
    {
        public SubInfo() { }
        public SubInfo(int id, string s_name, string value, string m_date)
        {
            measure_id = id;
            social_name = s_name;
            measure_value = value;
            measure_date = m_date;
        }
        public int measure_id { get; set; }
        public string social_name { get; set; }
        public string measure_value { get; set; }
        public string measure_date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP
{
    public class ReserveInfo
    {
        public ReserveInfo() { }
        public ReserveInfo(int id, string source, string date, string status) 
        {
            reserve_id = id;
            reserve_source = source;
            reserve_date = date;
            reserve_status = status;
        }

        public int reserve_id { get; set; }
        public string reserve_source { get; set; }
        public string reserve_date { get; set; }
        public string reserve_status { get; set; }
    }
}

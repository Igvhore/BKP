using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class EmployeeInVideo
    {
        public EmployeeInVideo() { }

        public EmployeeInVideo(int id, string name, string position)
        {
            employee_id = id;
            employee_name = name;
            employee_position = position;

        }

        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string employee_position { get; set; }

    }
}

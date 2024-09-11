using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP
{
    public class Employee
    {
        public Employee() { }
        public Employee (int id, string name, string skills, string position, string phone)
        {
            employee_id = id;
            employee_name = name;
            employee_skills = skills;
            employee_position = position;
            employee_phone = phone;

        }
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string employee_skills { get; set; }
        public string employee_position { get; set; }
        public string employee_phone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP
{
    public class Skills
    {
        public Skills() { }
        public Skills(int id, string name, string description)
        {
            skill_id = id;
            skill_name = name;
            skill_description = description;
        }
        public int skill_id { get; set; }
        public string skill_name { get; set; }
        public string skill_description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class Post
    {
        public Post() { }

        public Post(int id, string title, string description, string type, string date, string employee, string social)
        {
            post_id = id;
            post_title = title;
            post_description = description;
            post_type = type;
            post_date = date;
            post_employee = employee;
            post_social = social;

        }

        public Post(int id, string title, string type, string date, string employee, string social)
        {
            post_id = id;
            post_title = title;
            post_type = type;
            post_date = date;
            post_employee = employee;
            post_social = social;

        }
        public int post_id { get; set; }
        public string post_title { get; set; }
        public string post_description { get; set; }
        public string post_type { get; set; }
        public string post_date { get; set; }
        public string post_employee { get; set; }
        public string post_social { get; set; }

    }
}

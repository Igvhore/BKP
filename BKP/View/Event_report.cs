using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class Event_report
    {
        public Event_report() { }
        public Event_report(int id, string title, string description, string tasks, string date)
        {
            event_id = id;
            event_title = title;
            event_description = description;
            event_tasks = tasks;
            event_date = date;
        }

        public Event_report(int id, string title, string date)
        {
            event_id = id;
            event_title = title;
            event_date = date;
        }
        public int event_id { get; set; }
        public string event_title { get; set; }
        public string event_description { get; set; }
        public string event_tasks { get; set; }
        public string event_date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class TaskInfo
    {
        public TaskInfo() { }
        public TaskInfo(int id, string title, string description, string cr_base, string assign_date, string est_datem, string r_date, string employee_wgtt,string task_st)
        {
            task_id = id;
            task_title = title;
            task_description = description;
            created_base = cr_base;
            assignment_date = assign_date;
            estimated_date = est_datem;
            real_date = r_date;
            employee_who_gave_the_task = employee_wgtt;
            task_status = task_st;
        }
        public TaskInfo(int id, string title, string assign_date, string est_datem, string r_date)
        {
            task_id = id;
            task_title = title;
            assignment_date = assign_date;
            estimated_date = est_datem;
            real_date = r_date;
        }
        public int task_id { get; set; }
        public string task_title { get; set; }
        public string task_description { get; set; }
        public string created_base { get; set; }
        public string assignment_date { get; set; }
        public string estimated_date { get; set; }
        public string real_date { get; set; }
        public string employee_who_gave_the_task { get; set; }
        public string task_status { get; set; }

    }
}

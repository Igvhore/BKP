using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class Task_stat
    {
        public Task_stat() { }
        public Task_stat(int id, string title, string cr_base, string executor, string employee_wgtt, string task_st)
        {
            task_id = id;
            task_title = title;
            created_base = cr_base;
            employee_executor = executor;
            employee_who_gave_the_task = employee_wgtt;
            task_status = task_st;
        }
        public int task_id { get; set; }
        public string task_title { get; set; }
        public string created_base { get; set; }
        public string employee_executor { get; set; }
        public string employee_who_gave_the_task { get; set; }
        public string task_status { get; set; }
    }

    public class Task_status
    {
        public Task_status() { }
        public Task_status(string st_name, int amount)
        {
            status_name = st_name;
            task_amount = amount;
        }
        public string status_name { get; set; }
        public int task_amount { get; set; }
    }

    public class Task_employee_director
    {
        public Task_employee_director() { }
        public Task_employee_director(string dir_name, int amount)
        {
            director_name = dir_name;
            task_amount = amount;
        }
        public string director_name { get; set; }
        public int task_amount { get; set; }
    }

    public class Task_employee_executor
    {
        public Task_employee_executor() { }
        public Task_employee_executor(string ex_name, int amount)
        {
            executor_name = ex_name;
            task_amount = amount;
        }
        public string executor_name { get; set; }
        public int task_amount { get; set; }
    }
}
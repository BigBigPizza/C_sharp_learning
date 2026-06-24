using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker_2
{
    public class Task
    {
        public bool IsComplete { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskDueDate { get; set; }
        public Task(bool isComplete, string taskName, DateTime taskDueDate)
        {
            IsComplete = isComplete;
            TaskName = taskName;
            TaskDueDate = taskDueDate;
        }
    }
}

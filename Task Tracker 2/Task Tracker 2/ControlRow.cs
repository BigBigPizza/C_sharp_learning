using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracker_2
{
    public class ControlRow
    {
        public static ListViewItem TaskToRow(bool statusBool, string task, DateTime date)
        {
            string status = "In Progress";
            if (statusBool == false)
            {
                status = "Complete!";
            }

            ListViewItem newTask = new ListViewItem(status);
            

            newTask.SubItems.Add(task);
            newTask.SubItems.Add(date.ToShortDateString());
            
            return newTask;
        }
    }
}

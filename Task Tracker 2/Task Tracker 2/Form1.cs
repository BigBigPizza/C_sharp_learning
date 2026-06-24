using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracker_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstTimeLoad();

        }

        Dictionary<string, Task> masterTaskList = SaveHandler.LoadData() == null ? new Dictionary<string, Task>(): SaveHandler.LoadData();

        private void FirstTimeLoad()
        {
            if (masterTaskList != null)
            {
                foreach(var pair in masterTaskList)
                {
                    Task loadedTask = pair.Value;
                    ListViewItem newRow = ControlRow.TaskToRow(loadedTask.IsComplete, loadedTask.TaskName, loadedTask.TaskDueDate);

                    if (loadedTask.IsComplete != true)
                    {
                        newRow.BackColor = Color.Aquamarine;
                        newRow.SubItems[0].Text = "Complete!";
                    }

                    else if (loadedTask.TaskDueDate < DateTime.Today)
                    {
                        newRow.BackColor = Color.Red;
                    }

                    newRow.SubItems.Add(((int)(loadedTask.TaskDueDate - DateTime.Now).TotalDays).ToString());
                    TaskList.Items.Add(newRow);
                }
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskTextBox.Text != "")
            {
                string task = TaskTextBox.Text;
                DateTime date = TaskDateTimePicker.Value;

                while (masterTaskList.ContainsKey(task))
                {
                    int counter = 1;
                    task = TaskTextBox.Text + " " +counter;
                }

                Task newTask = new Task(true, task, date);
                ListViewItem newRow = ControlRow.TaskToRow(true, task, date);
                newRow.SubItems.Add(((int)(date - DateTime.Now).TotalDays).ToString());

                TaskList.Items.Add(newRow);
                masterTaskList.Add(newTask.TaskName, newTask);
                SaveHandler.SaveData(masterTaskList);

                TaskTextBox.Text = "";
            }
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskList.SelectedItems.Count > 0)
            {
                foreach(ListViewItem selectedTask in TaskList.SelectedItems)
                {
                    TaskList.Items.Remove(selectedTask);
                    masterTaskList.Remove(selectedTask.SubItems[1].Text);
                }
                SaveHandler.SaveData(masterTaskList);
            }
        }

        private void CompleteTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedTask in TaskList.SelectedItems)
                {
                    selectedTask.BackColor = Color.Aquamarine;
                    selectedTask.SubItems[0].Text = "Complete!";

                    string taskName = selectedTask.SubItems[1].Text;

                    Task task = masterTaskList[taskName];

                    task.IsComplete = false;

                    masterTaskList[taskName] = task;
                }
                SaveHandler.SaveData(masterTaskList);
            }
        }
    }
}

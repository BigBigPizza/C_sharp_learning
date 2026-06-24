namespace Task_Tracker_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskList = new System.Windows.Forms.ListView();
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DaysLeftColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskTextBox = new System.Windows.Forms.TextBox();
            this.TaskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.CompleteTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskList
            // 
            this.TaskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StatusColumn,
            this.TaskColumn,
            this.DueDateColumn,
            this.DaysLeftColumn});
            this.TaskList.FullRowSelect = true;
            this.TaskList.GridLines = true;
            this.TaskList.HideSelection = false;
            this.TaskList.Location = new System.Drawing.Point(37, 101);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(711, 308);
            this.TaskList.TabIndex = 0;
            this.TaskList.UseCompatibleStateImageBehavior = false;
            this.TaskList.View = System.Windows.Forms.View.Details;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 61;
            // 
            // TaskColumn
            // 
            this.TaskColumn.Text = "Task";
            this.TaskColumn.Width = 457;
            // 
            // DueDateColumn
            // 
            this.DueDateColumn.Text = "Due Date";
            this.DueDateColumn.Width = 93;
            // 
            // DaysLeftColumn
            // 
            this.DaysLeftColumn.Text = "Days Left";
            this.DaysLeftColumn.Width = 96;
            // 
            // TaskTextBox
            // 
            this.TaskTextBox.Location = new System.Drawing.Point(80, 45);
            this.TaskTextBox.Name = "TaskTextBox";
            this.TaskTextBox.Size = new System.Drawing.Size(394, 20);
            this.TaskTextBox.TabIndex = 1;
            // 
            // TaskDateTimePicker
            // 
            this.TaskDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TaskDateTimePicker.Location = new System.Drawing.Point(558, 45);
            this.TaskDateTimePicker.Name = "TaskDateTimePicker";
            this.TaskDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.TaskDateTimePicker.TabIndex = 2;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(673, 42);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(75, 23);
            this.AddTaskButton.TabIndex = 3;
            this.AddTaskButton.Text = "Add";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(34, 48);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(34, 13);
            this.TaskLabel.TabIndex = 4;
            this.TaskLabel.Text = "Task:";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(496, 47);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.DueDateLabel.TabIndex = 5;
            this.DueDateLabel.Text = "Due Date:";
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Location = new System.Drawing.Point(673, 72);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveTaskButton.TabIndex = 6;
            this.RemoveTaskButton.Text = "Remove";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // CompleteTaskButton
            // 
            this.CompleteTaskButton.Location = new System.Drawing.Point(673, 415);
            this.CompleteTaskButton.Name = "CompleteTaskButton";
            this.CompleteTaskButton.Size = new System.Drawing.Size(75, 23);
            this.CompleteTaskButton.TabIndex = 7;
            this.CompleteTaskButton.Text = "Complete!";
            this.CompleteTaskButton.UseVisualStyleBackColor = true;
            this.CompleteTaskButton.Click += new System.EventHandler(this.CompleteTaskButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompleteTaskButton);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.TaskDateTimePicker);
            this.Controls.Add(this.TaskTextBox);
            this.Controls.Add(this.TaskList);
            this.Name = "Form1";
            this.Text = "Task Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView TaskList;
        public System.Windows.Forms.ColumnHeader StatusColumn;
        public System.Windows.Forms.ColumnHeader TaskColumn;
        private System.Windows.Forms.ColumnHeader DueDateColumn;
        private System.Windows.Forms.ColumnHeader DaysLeftColumn;
        public System.Windows.Forms.TextBox TaskTextBox;
        public System.Windows.Forms.DateTimePicker TaskDateTimePicker;
        public System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Label DueDateLabel;
        public System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.Button CompleteTaskButton;
    }
}


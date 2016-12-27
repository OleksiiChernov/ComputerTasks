using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ki_14_5_lab4.Forms
{
    public partial class RemoveTaskFromComputer : Form
    {
        private EditComputer _editComputerForm;

        public RemoveTaskFromComputer(EditComputer editComputer)
        {
            InitializeComponent();
            _editComputerForm = editComputer;
            FillTaskList();
            TasksList.SelectedIndexChanged += TasksListOnSelectedIndexChanged;
        }

        private void TasksListOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            bool value = TasksList.SelectedIndex != -1;

            RemoveButton.Enabled = value;
        }

        private void FillTaskList()
        {
            TasksList.Items.Clear();
            TasksList.Items.AddRange(_editComputerForm.CurrentComputer.AddedTask.
                Select(task => task.TaskName).ToArray());
            RemoveButton.Enabled = false;
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Task task = _editComputerForm.CurrentComputer.AddedTask[TasksList.SelectedIndex];
            _editComputerForm.RemoveTask(task);
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class AddTaskToComputer : Form
    {
        private EditComputer _editComputerForm;

        public AddTaskToComputer(EditComputer editComputer)
        {
            InitializeComponent();
            _editComputerForm = editComputer;
            FillTaskList();
            TasksList.SelectedIndexChanged += TasksListOnSelectedIndexChanged;
        }

        private void TasksListOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            bool value = TasksList.SelectedIndex != -1;

            AddButton.Enabled = value;
        }

        private void FillTaskList()
        {
            TasksList.Items.Clear();
            TasksList.Items.AddRange(_editComputerForm.MainForm.CurrentComputerController.AvailableTaskList.
                Select(task=>task.TaskName).ToArray());
            AddButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Task task = _editComputerForm.MainForm.CurrentComputerController
                .AvailableTaskList[TasksList.SelectedIndex];
            _editComputerForm.AddTask(task);
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

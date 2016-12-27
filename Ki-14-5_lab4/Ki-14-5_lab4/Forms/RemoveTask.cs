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
    public partial class RemoveTask : Form
    {
        private MainForm _mainForm;

        public RemoveTask(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            FillList();
            TasksList.SelectedIndexChanged += TasksListOnSelectedIndexChanged;
        }

        private void TasksListOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            bool value = TasksList.SelectedIndex != -1;

            RemoveButton.Enabled = value;
        }

        private void FillList()
        {
            TasksList.Items.Clear();
            TasksList.Items.AddRange(_mainForm.CurrentComputerController.AvailableTaskList.
                Select(task=>task.TaskName).ToArray());
            RemoveButton.Enabled = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Task task = _mainForm.CurrentComputerController.AvailableTaskList[TasksList.SelectedIndex];
            _mainForm.CurrentComputerController.RemoveTask(task);
            FillList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

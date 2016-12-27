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
    public partial class EditComputer : Form
    {

        private MainForm _mainForm;
        private Computer _computerToEdit;

        public EditComputer(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            FillComputersList();
            AvailableComputers.SelectedIndexChanged += AvailableComputersOnSelectedIndexChanged;
        }

        public void AddTask(Task task)
        {
            if (null == task || null == _computerToEdit)
            {
                MessageBox.Show(Constants.Errors.NullData);
                return;
            }

            _mainForm.CurrentComputerController.AddTaskToComputer(_computerToEdit, task);
        }

        public void RemoveTask(Task task)
        {
            if (null == task || null == _computerToEdit)
            {
                MessageBox.Show(Constants.Errors.NullData);
                return;
            }

            _mainForm.CurrentComputerController.RemoveTaskFromComputer(_computerToEdit, task);
        }

        private void AvailableComputersOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            bool isEnable = AvailableComputers.SelectedIndex != -1;

            RemoveButton.Enabled = isEnable;
            AddTaskButton.Enabled = isEnable;
            RemoveTaskButton.Enabled = isEnable;

            _computerToEdit = _mainForm.CurrentComputerController.ComputersList[AvailableComputers.SelectedIndex];

        }

        private void FillComputersList()
        {
            AvailableComputers.Items.Clear();
            AvailableComputers.Items.AddRange(_mainForm.CurrentComputerController.ComputersList.Select(comp => comp.Name).ToArray());
            RemoveButton.Enabled = false;
            AddTaskButton.Enabled = false;
            RemoveTaskButton.Enabled = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selected = AvailableComputers.SelectedIndex;

            if (-1 == selected || selected > _mainForm.CurrentComputerController.AvailableComputersCount)
            {
                return;
            }

            _mainForm.CurrentComputerController.RemoveComputer(_mainForm.CurrentComputerController.ComputersList[selected]);
            FillComputersList();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskToComputer addTask = new AddTaskToComputer(this);
            addTask.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            RemoveTaskFromComputer removeTask = new RemoveTaskFromComputer(this);
            removeTask.ShowDialog();
        }

        #region Properties

        public MainForm MainForm
        {
            get { return _mainForm; }
        }

        public Computer CurrentComputer
        {
            get { return _computerToEdit; }
        }

        #endregion

    }
}

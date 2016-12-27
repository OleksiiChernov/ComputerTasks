using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ki_14_5_lab4.Forms;

namespace Ki_14_5_lab4
{
    public partial class MainForm : Form
    {

        #region Variables

        ComputerController _computerController;

        #endregion

        public MainForm()
        {
            _computerController = new ComputerController();
            InitializeComponent();

            _computerController.OnDataChanged += OnComputerControllerDataChanged;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateView()
        {
            UpdateComputersView();
            UpdateTaskView();
        }

        private void UpdateTaskView()
        {
            if (null == _computerController)
            {
                MessageBox.Show(Constants.Errors.NullComputerControllerMessage);
                return;
            }

            if (null == TaskList)
            {
                MessageBox.Show(Constants.Errors.NullTaskListViewMessage);
                return;
            }

            if (null == _computerController.AvailableTaskList)
            {
                MessageBox.Show(Constants.Errors.NullTaskListMessage);
            }

            TaskList.Items.Clear();
            TaskList.Items.AddRange(_computerController.AvailableTaskList.Select(task => task.TaskName).ToArray());
        }

        private void UpdateComputersView()
        {
            if (null == _computerController)
            {
                MessageBox.Show(Constants.Errors.NullComputerControllerMessage);
                return;
            }

            if (null == ComputerList)
            {
                MessageBox.Show(Constants.Errors.NullComputerTreeViewMessage);
                return;
            }

            if (null == _computerController.ComputersList)
            {
                MessageBox.Show(Constants.Errors.NullComputersListMessage);
            }

            List<TreeNode> computersToAdd = new List<TreeNode>();

            foreach (var computer in _computerController.ComputersList)
            {
                TreeNode node = new TreeNode(computer.Name);

                foreach (var task in computer.AddedTask)
                {
                    node.Nodes.Add(new TreeNode(task.ToString()));
                }
                computersToAdd.Add(node);
            }

            ComputerList.Nodes.Clear();
            ComputerList.Nodes.AddRange(computersToAdd.ToArray());
        }

        #region ButtonsOnClick

        private void AddComputerButton_Click(object sender, EventArgs e)
        {
            AddComputer addComputer = new AddComputer();
            addComputer.OnSaveButton += AddComputerDelegate;
            addComputer.ShowDialog();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.OnSaveButton += AddTaskSaveButtonHandler;
            addTask.ShowDialog();
        }

        private void AddTaskSaveButtonHandler(object sender, TaskEventArgs taskEventArgs)
        {
            _computerController.AddNewTask(taskEventArgs.TaskName , taskEventArgs.Date, false, taskEventArgs.TaskInfo);
        }

        private void OnComputerControllerDataChanged(object sender, EventArgs args)
        {
            UpdateView();
        }

        private void AddComputerDelegate(object sender, ComputerEventArgs args)
        {
            _computerController.AddComputer(new Computer(args.ComputerName, args.IsAvailable));
        }

        #endregion


        #region Properties

        public ComputerController CurrentComputerController
        {
            get { return _computerController; }
        }

        #endregion

        private void EditComputerButton_Click(object sender, EventArgs e)
        {
            EditComputer edit = new EditComputer(this);
            edit.ShowDialog();
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            RemoveTask removeTask = new RemoveTask(this);
            removeTask.ShowDialog();
        }

        private void CompareComputersButton_Click(object sender, EventArgs e)
        {
            CompareComputers compare = new CompareComputers(this);
            compare.ShowDialog();
        }
    }
}

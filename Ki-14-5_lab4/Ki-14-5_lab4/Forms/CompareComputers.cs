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
    public partial class CompareComputers : Form
    {
        private MainForm _mainForm ;

        private int _firstComputerIndex;
        private int _secondComputerIndex;

        public CompareComputers(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            FillList(FirstPC);
            FillList(SecondPC);

            FirstPC.SelectedIndexChanged += FirstPcOnSelectedIndexChanged;
            SecondPC.SelectedIndexChanged += SecondPcOnSelectedIndexChanged;

        }

        private void FirstPcOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            _firstComputerIndex = FirstPC.SelectedIndex;

            bool value = _firstComputerIndex == -1 || _secondComputerIndex == -1 ||
                         _firstComputerIndex == _secondComputerIndex;

            //if (true == value)
            //{
            //    MessageBox.Show(Constants.Errors.IncorrectArgumentMessage);
            //}

            CompareButton.Enabled = !value;
        }

        private void SecondPcOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            _secondComputerIndex = SecondPC.SelectedIndex;

            bool value = _firstComputerIndex == -1 || _secondComputerIndex == -1 ||
                         _firstComputerIndex == _secondComputerIndex;

            //if (true == value)
            //{
            //    MessageBox.Show(Constants.Errors.IncorrectArgumentMessage);
            //}

            CompareButton.Enabled = !value;
        }

        private void Compare()
        {
            Computer firstComputer = _mainForm.CurrentComputerController.ComputersList[_firstComputerIndex];
            Computer secondComputer = _mainForm.CurrentComputerController.ComputersList[_secondComputerIndex];

            FillNode(firstComputer , FirstPCTree);
            FillNode(secondComputer, SecondPCTree);
        }

        private void Clean()
        {
            FirstPC.SelectedIndex = -1;
            SecondPC.SelectedIndex = -1;

            FirstPCTree.Nodes.Clear();
            SecondPCTree.Nodes.Clear();

        }

        private void FillNode(Computer comp, TreeView view)
        {
            TreeNode node = new TreeNode(comp.Name);

            foreach (var task in comp.AddedTask)
            {
                node.Nodes.Add(new TreeNode(task.ToString()));
            }
            view.Nodes.Clear();
            view.Nodes.Add(node);
        }

        private void FillList(ListBox listToFill)
        {
            listToFill.Items.Clear();
            listToFill.Items.AddRange(_mainForm.CurrentComputerController.ComputersList.Select(comp => comp.Name).ToArray());
            CompareButton.Enabled = false;
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

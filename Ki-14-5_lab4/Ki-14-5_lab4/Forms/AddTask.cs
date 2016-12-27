using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ki_14_5_lab4
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        public EventHandler<TaskEventArgs> OnSaveButton { get; set; }

        private void Save_Click(object sender, EventArgs e)
        {
            if (null != OnSaveButton)
            {
                OnSaveButton(this, new TaskEventArgs(taskName.Text , taskInfo.Text, taskDate.Value));
            }
            Close();
        }
    }
}

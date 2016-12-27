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
    public partial class AddComputer : Form
    {
        public AddComputer()
        {
            InitializeComponent();
        }

        public EventHandler<ComputerEventArgs> OnSaveButton { get; set; }

        private void save_Click_1(object sender, EventArgs e)
        {
            if (null != OnSaveButton)
            {
                OnSaveButton(this, new ComputerEventArgs(ComputerName.Text, ComputerCheckBox.Checked));
            }
            Close();
        }
    }
}

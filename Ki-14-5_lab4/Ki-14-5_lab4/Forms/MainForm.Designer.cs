namespace Ki_14_5_lab4
{
    partial class MainForm
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
            this.ComputerList = new System.Windows.Forms.TreeView();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.ComputersListLabel = new System.Windows.Forms.Label();
            this.AddComputerButton = new System.Windows.Forms.Button();
            this.CompareComputersButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.TasksLabel = new System.Windows.Forms.Label();
            this.EditComputerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComputerList
            // 
            this.ComputerList.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputerList.Location = new System.Drawing.Point(12, 46);
            this.ComputerList.Name = "ComputerList";
            this.ComputerList.Size = new System.Drawing.Size(578, 160);
            this.ComputerList.TabIndex = 0;
            // 
            // TaskList
            // 
            this.TaskList.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 23;
            this.TaskList.Location = new System.Drawing.Point(340, 256);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(250, 165);
            this.TaskList.TabIndex = 1;
            // 
            // ComputersListLabel
            // 
            this.ComputersListLabel.AutoSize = true;
            this.ComputersListLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputersListLabel.Location = new System.Drawing.Point(231, 20);
            this.ComputersListLabel.Name = "ComputersListLabel";
            this.ComputersListLabel.Size = new System.Drawing.Size(149, 23);
            this.ComputersListLabel.TabIndex = 2;
            this.ComputersListLabel.Text = "Computers list";
            // 
            // AddComputerButton
            // 
            this.AddComputerButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddComputerButton.Location = new System.Drawing.Point(78, 264);
            this.AddComputerButton.Name = "AddComputerButton";
            this.AddComputerButton.Size = new System.Drawing.Size(192, 29);
            this.AddComputerButton.TabIndex = 3;
            this.AddComputerButton.Text = "Add computer";
            this.AddComputerButton.UseVisualStyleBackColor = true;
            this.AddComputerButton.Click += new System.EventHandler(this.AddComputerButton_Click);
            // 
            // CompareComputersButton
            // 
            this.CompareComputersButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompareComputersButton.Location = new System.Drawing.Point(78, 334);
            this.CompareComputersButton.Name = "CompareComputersButton";
            this.CompareComputersButton.Size = new System.Drawing.Size(192, 29);
            this.CompareComputersButton.TabIndex = 5;
            this.CompareComputersButton.Text = "Compare computers";
            this.CompareComputersButton.UseVisualStyleBackColor = true;
            this.CompareComputersButton.Click += new System.EventHandler(this.CompareComputersButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskButton.Location = new System.Drawing.Point(78, 369);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(192, 29);
            this.AddTaskButton.TabIndex = 6;
            this.AddTaskButton.Text = "Add task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveTaskButton.Location = new System.Drawing.Point(78, 404);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(192, 29);
            this.RemoveTaskButton.TabIndex = 7;
            this.RemoveTaskButton.Text = "Remove task";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // TasksLabel
            // 
            this.TasksLabel.AutoSize = true;
            this.TasksLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasksLabel.Location = new System.Drawing.Point(441, 230);
            this.TasksLabel.Name = "TasksLabel";
            this.TasksLabel.Size = new System.Drawing.Size(62, 23);
            this.TasksLabel.TabIndex = 8;
            this.TasksLabel.Text = "Tasks";
            // 
            // EditComputerButton
            // 
            this.EditComputerButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditComputerButton.Location = new System.Drawing.Point(78, 299);
            this.EditComputerButton.Name = "EditComputerButton";
            this.EditComputerButton.Size = new System.Drawing.Size(192, 29);
            this.EditComputerButton.TabIndex = 9;
            this.EditComputerButton.Text = "Edit computer";
            this.EditComputerButton.UseVisualStyleBackColor = true;
            this.EditComputerButton.Click += new System.EventHandler(this.EditComputerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(602, 440);
            this.Controls.Add(this.EditComputerButton);
            this.Controls.Add(this.TasksLabel);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.CompareComputersButton);
            this.Controls.Add(this.AddComputerButton);
            this.Controls.Add(this.ComputersListLabel);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.ComputerList);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ComputerList;
        private System.Windows.Forms.ListBox TaskList;
        private System.Windows.Forms.Label ComputersListLabel;
        private System.Windows.Forms.Button AddComputerButton;
        private System.Windows.Forms.Button CompareComputersButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.Label TasksLabel;
        private System.Windows.Forms.Button EditComputerButton;
    }
}
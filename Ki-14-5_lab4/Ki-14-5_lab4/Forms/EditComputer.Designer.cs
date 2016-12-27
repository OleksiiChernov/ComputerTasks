namespace Ki_14_5_lab4.Forms
{
    partial class EditComputer
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
            this.AvailableComputers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AvailableComputers
            // 
            this.AvailableComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableComputers.FormattingEnabled = true;
            this.AvailableComputers.ItemHeight = 20;
            this.AvailableComputers.Location = new System.Drawing.Point(12, 32);
            this.AvailableComputers.Name = "AvailableComputers";
            this.AvailableComputers.Size = new System.Drawing.Size(260, 164);
            this.AvailableComputers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select computer to edit";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 202);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(87, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(99, 202);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(85, 23);
            this.AddTaskButton.TabIndex = 3;
            this.AddTaskButton.Text = "Add task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Location = new System.Drawing.Point(185, 202);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(87, 23);
            this.RemoveTaskButton.TabIndex = 4;
            this.RemoveTaskButton.Text = "Remove task";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(99, 231);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailableComputers);
            this.Name = "EditComputer";
            this.Text = "RemoveComputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailableComputers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.Button CloseButton;
    }
}
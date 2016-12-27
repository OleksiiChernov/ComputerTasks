namespace Ki_14_5_lab4.Forms
{
    partial class CompareComputers
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
            this.FirstPC = new System.Windows.Forms.ListBox();
            this.SecondPC = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompareButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SecondPCTree = new System.Windows.Forms.TreeView();
            this.FirstPCTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // FirstPC
            // 
            this.FirstPC.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPC.FormattingEnabled = true;
            this.FirstPC.ItemHeight = 23;
            this.FirstPC.Location = new System.Drawing.Point(12, 28);
            this.FirstPC.Name = "FirstPC";
            this.FirstPC.Size = new System.Drawing.Size(185, 165);
            this.FirstPC.TabIndex = 0;
            // 
            // SecondPC
            // 
            this.SecondPC.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondPC.FormattingEnabled = true;
            this.SecondPC.ItemHeight = 23;
            this.SecondPC.Location = new System.Drawing.Point(370, 28);
            this.SecondPC.Name = "SecondPC";
            this.SecondPC.Size = new System.Drawing.Size(185, 165);
            this.SecondPC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select 2 computers to compare";
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(247, 43);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(75, 23);
            this.CompareButton.TabIndex = 3;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(247, 72);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 4;
            this.CleanButton.Text = "Clean";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(247, 101);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SecondPCTree
            // 
            this.SecondPCTree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondPCTree.Location = new System.Drawing.Point(289, 265);
            this.SecondPCTree.Name = "SecondPCTree";
            this.SecondPCTree.Size = new System.Drawing.Size(266, 189);
            this.SecondPCTree.TabIndex = 6;
            // 
            // FirstPCTree
            // 
            this.FirstPCTree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPCTree.Location = new System.Drawing.Point(12, 265);
            this.FirstPCTree.Name = "FirstPCTree";
            this.FirstPCTree.Size = new System.Drawing.Size(266, 189);
            this.FirstPCTree.TabIndex = 7;
            // 
            // CompareComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 493);
            this.Controls.Add(this.FirstPCTree);
            this.Controls.Add(this.SecondPCTree);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPC);
            this.Controls.Add(this.FirstPC);
            this.Name = "CompareComputers";
            this.Text = "CompareComputers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FirstPC;
        private System.Windows.Forms.ListBox SecondPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TreeView SecondPCTree;
        private System.Windows.Forms.TreeView FirstPCTree;
    }
}
namespace COTWSaveManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SetActiveButton = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.ListBox();
            this.SaveNameInput = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetActiveButton
            // 
            this.SetActiveButton.Location = new System.Drawing.Point(12, 12);
            this.SetActiveButton.Name = "SetActiveButton";
            this.SetActiveButton.Size = new System.Drawing.Size(75, 23);
            this.SetActiveButton.TabIndex = 0;
            this.SetActiveButton.Text = "Set Active";
            this.SetActiveButton.UseVisualStyleBackColor = true;
            this.SetActiveButton.Click += new System.EventHandler(this.SetActiveButton_Click);
            // 
            // SaveList
            // 
            this.SaveList.FormattingEnabled = true;
            this.SaveList.Location = new System.Drawing.Point(12, 41);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(434, 394);
            this.SaveList.TabIndex = 1;
            // 
            // SaveNameInput
            // 
            this.SaveNameInput.Location = new System.Drawing.Point(93, 12);
            this.SaveNameInput.Name = "SaveNameInput";
            this.SaveNameInput.Size = new System.Drawing.Size(110, 20);
            this.SaveNameInput.TabIndex = 2;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(209, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(290, 12);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(75, 23);
            this.RenameButton.TabIndex = 4;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(371, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SaveNameInput);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.SetActiveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "theHunter COTW Save Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetActiveButton;
        private System.Windows.Forms.ListBox SaveList;
        private System.Windows.Forms.TextBox SaveNameInput;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}


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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabControl Tabs;
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.TabPage tabPage2;
            System.Windows.Forms.GroupBox experimentalBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SetActiveButton = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.ListBox();
            this.SaveNameInput = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.keepSettingsBox = new System.Windows.Forms.CheckBox();
            this.keepAchievesBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.keepFOWBox = new System.Windows.Forms.CheckBox();
            this.keepIconsBox = new System.Windows.Forms.CheckBox();
            this.keepNeedZBox = new System.Windows.Forms.CheckBox();
            this.keepDogBox = new System.Windows.Forms.CheckBox();
            Tabs = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            experimentalBox = new System.Windows.Forms.GroupBox();
            Tabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            experimentalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetActiveButton
            // 
            this.SetActiveButton.Location = new System.Drawing.Point(3, 3);
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
            this.SaveList.Location = new System.Drawing.Point(3, 32);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(434, 381);
            this.SaveList.TabIndex = 1;
            // 
            // SaveNameInput
            // 
            this.SaveNameInput.Location = new System.Drawing.Point(84, 3);
            this.SaveNameInput.Name = "SaveNameInput";
            this.SaveNameInput.Size = new System.Drawing.Size(110, 20);
            this.SaveNameInput.TabIndex = 2;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(200, 3);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(281, 3);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(75, 23);
            this.RenameButton.TabIndex = 4;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(362, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Tabs
            // 
            Tabs.Controls.Add(tabPage1);
            Tabs.Controls.Add(tabPage2);
            Tabs.Location = new System.Drawing.Point(3, 1);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new System.Drawing.Size(464, 448);
            Tabs.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.DeleteButton);
            tabPage1.Controls.Add(this.SetActiveButton);
            tabPage1.Controls.Add(this.RenameButton);
            tabPage1.Controls.Add(this.SaveList);
            tabPage1.Controls.Add(this.CreateButton);
            tabPage1.Controls.Add(this.SaveNameInput);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(456, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Saves";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(experimentalBox);
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(456, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // keepSettingsBox
            // 
            this.keepSettingsBox.AutoSize = true;
            this.keepSettingsBox.Location = new System.Drawing.Point(6, 19);
            this.keepSettingsBox.Name = "keepSettingsBox";
            this.keepSettingsBox.Size = new System.Drawing.Size(90, 17);
            this.keepSettingsBox.TabIndex = 1;
            this.keepSettingsBox.Text = "Keep settings";
            this.toolTip1.SetToolTip(this.keepSettingsBox, "Preserves in game settings and keybindings.");
            this.keepSettingsBox.UseVisualStyleBackColor = true;
            this.keepSettingsBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // keepAchievesBox
            // 
            this.keepAchievesBox.AutoSize = true;
            this.keepAchievesBox.Location = new System.Drawing.Point(6, 42);
            this.keepAchievesBox.Name = "keepAchievesBox";
            this.keepAchievesBox.Size = new System.Drawing.Size(120, 17);
            this.keepAchievesBox.TabIndex = 2;
            this.keepAchievesBox.Text = "Keep achievements";
            this.toolTip1.SetToolTip(this.keepAchievesBox, "Preserves achievements and mission data.");
            this.keepAchievesBox.UseVisualStyleBackColor = true;
            this.keepAchievesBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // keepFOWBox
            // 
            this.keepFOWBox.AutoSize = true;
            this.keepFOWBox.Location = new System.Drawing.Point(6, 65);
            this.keepFOWBox.Name = "keepFOWBox";
            this.keepFOWBox.Size = new System.Drawing.Size(79, 17);
            this.keepFOWBox.TabIndex = 3;
            this.keepFOWBox.Text = "Keep FOW";
            this.toolTip1.SetToolTip(this.keepFOWBox, "Preserves fog of war, the lighter (explored) areas of the map.");
            this.keepFOWBox.UseVisualStyleBackColor = true;
            this.keepFOWBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // keepIconsBox
            // 
            this.keepIconsBox.AutoSize = true;
            this.keepIconsBox.Location = new System.Drawing.Point(6, 88);
            this.keepIconsBox.Name = "keepIconsBox";
            this.keepIconsBox.Size = new System.Drawing.Size(79, 17);
            this.keepIconsBox.TabIndex = 4;
            this.keepIconsBox.Text = "Keep icons";
            this.toolTip1.SetToolTip(this.keepIconsBox, "Preserves found outposts, hunting stands, landmarks, etc.");
            this.keepIconsBox.UseVisualStyleBackColor = true;
            this.keepIconsBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // keepNeedZBox
            // 
            this.keepNeedZBox.AutoSize = true;
            this.keepNeedZBox.Location = new System.Drawing.Point(6, 111);
            this.keepNeedZBox.Name = "keepNeedZBox";
            this.keepNeedZBox.Size = new System.Drawing.Size(109, 17);
            this.keepNeedZBox.TabIndex = 5;
            this.keepNeedZBox.Text = "Keep need zones";
            this.toolTip1.SetToolTip(this.keepNeedZBox, "Preserves found need zones.");
            this.keepNeedZBox.UseVisualStyleBackColor = true;
            this.keepNeedZBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // keepDogBox
            // 
            this.keepDogBox.AutoSize = true;
            this.keepDogBox.Location = new System.Drawing.Point(6, 134);
            this.keepDogBox.Name = "keepDogBox";
            this.keepDogBox.Size = new System.Drawing.Size(103, 17);
            this.keepDogBox.TabIndex = 6;
            this.keepDogBox.Text = "Keep dog profile";
            this.toolTip1.SetToolTip(this.keepDogBox, "Preserves dog progress.");
            this.keepDogBox.UseVisualStyleBackColor = true;
            this.keepDogBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // experimentalBox
            // 
            experimentalBox.Controls.Add(this.keepSettingsBox);
            experimentalBox.Controls.Add(this.keepDogBox);
            experimentalBox.Controls.Add(this.keepAchievesBox);
            experimentalBox.Controls.Add(this.keepNeedZBox);
            experimentalBox.Controls.Add(this.keepFOWBox);
            experimentalBox.Controls.Add(this.keepIconsBox);
            experimentalBox.Location = new System.Drawing.Point(6, 6);
            experimentalBox.Name = "experimentalBox";
            experimentalBox.Size = new System.Drawing.Size(232, 409);
            experimentalBox.TabIndex = 7;
            experimentalBox.TabStop = false;
            experimentalBox.Text = "Experimental";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "theHunter COTW Save Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            Tabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            experimentalBox.ResumeLayout(false);
            experimentalBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetActiveButton;
        private System.Windows.Forms.ListBox SaveList;
        private System.Windows.Forms.TextBox SaveNameInput;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox keepAchievesBox;
        private System.Windows.Forms.CheckBox keepSettingsBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox keepFOWBox;
        private System.Windows.Forms.CheckBox keepIconsBox;
        private System.Windows.Forms.CheckBox keepNeedZBox;
        private System.Windows.Forms.CheckBox keepDogBox;
    }
}


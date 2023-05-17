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
            System.Windows.Forms.TabPage SavesTab;
            System.Windows.Forms.TabPage BackupsTab;
            System.Windows.Forms.GroupBox BackupsBox;
            System.Windows.Forms.GroupBox SavesBox;
            System.Windows.Forms.TabPage SettingsTab;
            System.Windows.Forms.GroupBox optionsBox;
            System.Windows.Forms.GroupBox experimentalBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SetActiveButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.ListBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SaveNameInput = new System.Windows.Forms.TextBox();
            this.BackupAllButton = new System.Windows.Forms.Button();
            this.bckpSetActiveButton = new System.Windows.Forms.Button();
            this.BackupDeleteButton = new System.Windows.Forms.Button();
            this.backupList = new System.Windows.Forms.ListBox();
            this.bckpSaveList = new System.Windows.Forms.ListBox();
            this.BackupButton = new System.Windows.Forms.Button();
            this.setStoreLocationButton = new System.Windows.Forms.Button();
            this.keepSettingsBox = new System.Windows.Forms.CheckBox();
            this.keepDogBox = new System.Windows.Forms.CheckBox();
            this.keepAchievesBox = new System.Windows.Forms.CheckBox();
            this.keepNeedZBox = new System.Windows.Forms.CheckBox();
            this.keepFOWBox = new System.Windows.Forms.CheckBox();
            this.keepIconsBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.keepPopulationBox = new System.Windows.Forms.CheckBox();
            Tabs = new System.Windows.Forms.TabControl();
            SavesTab = new System.Windows.Forms.TabPage();
            BackupsTab = new System.Windows.Forms.TabPage();
            BackupsBox = new System.Windows.Forms.GroupBox();
            SavesBox = new System.Windows.Forms.GroupBox();
            SettingsTab = new System.Windows.Forms.TabPage();
            optionsBox = new System.Windows.Forms.GroupBox();
            experimentalBox = new System.Windows.Forms.GroupBox();
            Tabs.SuspendLayout();
            SavesTab.SuspendLayout();
            BackupsTab.SuspendLayout();
            BackupsBox.SuspendLayout();
            SavesBox.SuspendLayout();
            SettingsTab.SuspendLayout();
            optionsBox.SuspendLayout();
            experimentalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(SavesTab);
            Tabs.Controls.Add(BackupsTab);
            Tabs.Controls.Add(SettingsTab);
            Tabs.Location = new System.Drawing.Point(3, 1);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new System.Drawing.Size(464, 448);
            Tabs.TabIndex = 6;
            // 
            // SavesTab
            // 
            SavesTab.Controls.Add(this.DeleteButton);
            SavesTab.Controls.Add(this.SetActiveButton);
            SavesTab.Controls.Add(this.RenameButton);
            SavesTab.Controls.Add(this.SaveList);
            SavesTab.Controls.Add(this.CreateButton);
            SavesTab.Controls.Add(this.SaveNameInput);
            SavesTab.Location = new System.Drawing.Point(4, 22);
            SavesTab.Name = "SavesTab";
            SavesTab.Padding = new System.Windows.Forms.Padding(3);
            SavesTab.Size = new System.Drawing.Size(456, 422);
            SavesTab.TabIndex = 0;
            SavesTab.Text = "Saves";
            SavesTab.UseVisualStyleBackColor = true;
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
            // SaveList
            // 
            this.SaveList.FormattingEnabled = true;
            this.SaveList.Location = new System.Drawing.Point(3, 32);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(434, 381);
            this.SaveList.TabIndex = 1;
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
            // SaveNameInput
            // 
            this.SaveNameInput.Location = new System.Drawing.Point(84, 5);
            this.SaveNameInput.Name = "SaveNameInput";
            this.SaveNameInput.Size = new System.Drawing.Size(110, 20);
            this.SaveNameInput.TabIndex = 2;
            // 
            // BackupsTab
            // 
            BackupsTab.Controls.Add(this.BackupAllButton);
            BackupsTab.Controls.Add(this.bckpSetActiveButton);
            BackupsTab.Controls.Add(this.BackupDeleteButton);
            BackupsTab.Controls.Add(BackupsBox);
            BackupsTab.Controls.Add(SavesBox);
            BackupsTab.Controls.Add(this.BackupButton);
            BackupsTab.Location = new System.Drawing.Point(4, 22);
            BackupsTab.Name = "BackupsTab";
            BackupsTab.Padding = new System.Windows.Forms.Padding(3);
            BackupsTab.Size = new System.Drawing.Size(456, 422);
            BackupsTab.TabIndex = 2;
            BackupsTab.Text = "Backups";
            BackupsTab.UseVisualStyleBackColor = true;
            // 
            // BackupAllButton
            // 
            this.BackupAllButton.Location = new System.Drawing.Point(84, 3);
            this.BackupAllButton.Name = "BackupAllButton";
            this.BackupAllButton.Size = new System.Drawing.Size(75, 23);
            this.BackupAllButton.TabIndex = 8;
            this.BackupAllButton.Text = "Backup All";
            this.BackupAllButton.UseVisualStyleBackColor = true;
            this.BackupAllButton.Click += new System.EventHandler(this.BackupAllButton_Click);
            // 
            // bckpSetActiveButton
            // 
            this.bckpSetActiveButton.Enabled = false;
            this.bckpSetActiveButton.Location = new System.Drawing.Point(246, 3);
            this.bckpSetActiveButton.Name = "bckpSetActiveButton";
            this.bckpSetActiveButton.Size = new System.Drawing.Size(75, 23);
            this.bckpSetActiveButton.TabIndex = 7;
            this.bckpSetActiveButton.Text = "Set Active";
            this.toolTip1.SetToolTip(this.bckpSetActiveButton, "Stores active save and loads backup into active.");
            this.bckpSetActiveButton.UseVisualStyleBackColor = true;
            // 
            // BackupDeleteButton
            // 
            this.BackupDeleteButton.Location = new System.Drawing.Point(165, 3);
            this.BackupDeleteButton.Name = "BackupDeleteButton";
            this.BackupDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.BackupDeleteButton.TabIndex = 6;
            this.BackupDeleteButton.Text = "Delete";
            this.BackupDeleteButton.UseVisualStyleBackColor = true;
            this.BackupDeleteButton.Click += new System.EventHandler(this.BackupDeleteButton_Click);
            // 
            // BackupsBox
            // 
            BackupsBox.Controls.Add(this.backupList);
            BackupsBox.Location = new System.Drawing.Point(227, 29);
            BackupsBox.Name = "BackupsBox";
            BackupsBox.Size = new System.Drawing.Size(223, 390);
            BackupsBox.TabIndex = 5;
            BackupsBox.TabStop = false;
            BackupsBox.Text = "Backups";
            // 
            // backupList
            // 
            this.backupList.FormattingEnabled = true;
            this.backupList.Location = new System.Drawing.Point(6, 15);
            this.backupList.Name = "backupList";
            this.backupList.Size = new System.Drawing.Size(211, 368);
            this.backupList.TabIndex = 2;
            // 
            // SavesBox
            // 
            SavesBox.Controls.Add(this.bckpSaveList);
            SavesBox.Location = new System.Drawing.Point(3, 29);
            SavesBox.Name = "SavesBox";
            SavesBox.Size = new System.Drawing.Size(223, 390);
            SavesBox.TabIndex = 4;
            SavesBox.TabStop = false;
            SavesBox.Text = "Saves";
            // 
            // bckpSaveList
            // 
            this.bckpSaveList.FormattingEnabled = true;
            this.bckpSaveList.Location = new System.Drawing.Point(6, 15);
            this.bckpSaveList.Name = "bckpSaveList";
            this.bckpSaveList.Size = new System.Drawing.Size(211, 368);
            this.bckpSaveList.TabIndex = 2;
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(3, 3);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(75, 23);
            this.BackupButton.TabIndex = 3;
            this.BackupButton.Text = "Backup";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // SettingsTab
            // 
            SettingsTab.Controls.Add(optionsBox);
            SettingsTab.Controls.Add(experimentalBox);
            SettingsTab.Location = new System.Drawing.Point(4, 22);
            SettingsTab.Name = "SettingsTab";
            SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            SettingsTab.Size = new System.Drawing.Size(456, 422);
            SettingsTab.TabIndex = 1;
            SettingsTab.Text = "Settings";
            SettingsTab.UseVisualStyleBackColor = true;
            // 
            // optionsBox
            // 
            optionsBox.Controls.Add(this.setStoreLocationButton);
            optionsBox.Location = new System.Drawing.Point(3, 6);
            optionsBox.Name = "optionsBox";
            optionsBox.Size = new System.Drawing.Size(223, 409);
            optionsBox.TabIndex = 8;
            optionsBox.TabStop = false;
            optionsBox.Text = "Options";
            // 
            // setStoreLocationButton
            // 
            this.setStoreLocationButton.Location = new System.Drawing.Point(6, 19);
            this.setStoreLocationButton.Name = "setStoreLocationButton";
            this.setStoreLocationButton.Size = new System.Drawing.Size(105, 23);
            this.setStoreLocationButton.TabIndex = 0;
            this.setStoreLocationButton.Text = "Set store location";
            this.toolTip1.SetToolTip(this.setStoreLocationButton, "Change where inactives saves are kept.");
            this.setStoreLocationButton.UseVisualStyleBackColor = true;
            this.setStoreLocationButton.Click += new System.EventHandler(this.SetStoreLocationButton_Click);
            // 
            // experimentalBox
            // 
            experimentalBox.Controls.Add(this.keepPopulationBox);
            experimentalBox.Controls.Add(this.keepSettingsBox);
            experimentalBox.Controls.Add(this.keepDogBox);
            experimentalBox.Controls.Add(this.keepAchievesBox);
            experimentalBox.Controls.Add(this.keepNeedZBox);
            experimentalBox.Controls.Add(this.keepFOWBox);
            experimentalBox.Controls.Add(this.keepIconsBox);
            experimentalBox.Location = new System.Drawing.Point(227, 6);
            experimentalBox.Name = "experimentalBox";
            experimentalBox.Size = new System.Drawing.Size(223, 409);
            experimentalBox.TabIndex = 7;
            experimentalBox.TabStop = false;
            experimentalBox.Text = "Experimental";
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
            // keepPopulationBox
            // 
            this.keepPopulationBox.AutoSize = true;
            this.keepPopulationBox.Location = new System.Drawing.Point(5, 157);
            this.keepPopulationBox.Name = "keepPopulationBox";
            this.keepPopulationBox.Size = new System.Drawing.Size(136, 17);
            this.keepPopulationBox.TabIndex = 7;
            this.keepPopulationBox.Text = "Keep animal population";
            this.toolTip1.SetToolTip(this.keepPopulationBox, "Preserves dog progress.");
            this.keepPopulationBox.UseVisualStyleBackColor = true;
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
            SavesTab.ResumeLayout(false);
            SavesTab.PerformLayout();
            BackupsTab.ResumeLayout(false);
            BackupsBox.ResumeLayout(false);
            SavesBox.ResumeLayout(false);
            SettingsTab.ResumeLayout(false);
            optionsBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button setStoreLocationButton;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.ListBox bckpSaveList;
        private System.Windows.Forms.ListBox backupList;
        private System.Windows.Forms.Button BackupDeleteButton;
        private System.Windows.Forms.Button bckpSetActiveButton;
        private System.Windows.Forms.Button BackupAllButton;
        private System.Windows.Forms.CheckBox keepPopulationBox;
    }
}


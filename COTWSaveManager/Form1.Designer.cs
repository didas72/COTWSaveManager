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
            System.Windows.Forms.Button DeleteButton;
            System.Windows.Forms.Button RenameButton;
            System.Windows.Forms.Button CreateButton;
            System.Windows.Forms.TabPage BackupsTab;
            System.Windows.Forms.Button BackupAllButton;
            System.Windows.Forms.Button bckpSetActiveButton;
            System.Windows.Forms.Button BackupDeleteButton;
            System.Windows.Forms.GroupBox BackupsBox;
            System.Windows.Forms.GroupBox SavesBox;
            System.Windows.Forms.Button BackupButton;
            System.Windows.Forms.TabPage SettingsTab;
            System.Windows.Forms.GroupBox OptionsBox;
            System.Windows.Forms.GroupBox ExperimentalBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SetActiveButton = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.ListBox();
            this.SaveNameInput = new System.Windows.Forms.TextBox();
            this.BackupList = new System.Windows.Forms.ListBox();
            this.BckpSaveList = new System.Windows.Forms.ListBox();
            this.SetStoreLocationButton = new System.Windows.Forms.Button();
            this.KeepPopulationBox = new System.Windows.Forms.CheckBox();
            this.KeepSettingsBox = new System.Windows.Forms.CheckBox();
            this.KeepDogBox = new System.Windows.Forms.CheckBox();
            this.KeepAchievesBox = new System.Windows.Forms.CheckBox();
            this.KeepNeedZBox = new System.Windows.Forms.CheckBox();
            this.KeepFOWBox = new System.Windows.Forms.CheckBox();
            this.KeepIconsBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MiscTab = new System.Windows.Forms.TabPage();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ChkUpdateButton = new System.Windows.Forms.Button();
            this.ReportBugButtom = new System.Windows.Forms.Button();
            Tabs = new System.Windows.Forms.TabControl();
            SavesTab = new System.Windows.Forms.TabPage();
            DeleteButton = new System.Windows.Forms.Button();
            RenameButton = new System.Windows.Forms.Button();
            CreateButton = new System.Windows.Forms.Button();
            BackupsTab = new System.Windows.Forms.TabPage();
            BackupAllButton = new System.Windows.Forms.Button();
            bckpSetActiveButton = new System.Windows.Forms.Button();
            BackupDeleteButton = new System.Windows.Forms.Button();
            BackupsBox = new System.Windows.Forms.GroupBox();
            SavesBox = new System.Windows.Forms.GroupBox();
            BackupButton = new System.Windows.Forms.Button();
            SettingsTab = new System.Windows.Forms.TabPage();
            OptionsBox = new System.Windows.Forms.GroupBox();
            ExperimentalBox = new System.Windows.Forms.GroupBox();
            Tabs.SuspendLayout();
            SavesTab.SuspendLayout();
            BackupsTab.SuspendLayout();
            BackupsBox.SuspendLayout();
            SavesBox.SuspendLayout();
            SettingsTab.SuspendLayout();
            OptionsBox.SuspendLayout();
            ExperimentalBox.SuspendLayout();
            this.MiscTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(SavesTab);
            Tabs.Controls.Add(BackupsTab);
            Tabs.Controls.Add(SettingsTab);
            Tabs.Controls.Add(this.MiscTab);
            Tabs.Location = new System.Drawing.Point(3, 1);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new System.Drawing.Size(464, 448);
            Tabs.TabIndex = 6;
            // 
            // SavesTab
            // 
            SavesTab.Controls.Add(DeleteButton);
            SavesTab.Controls.Add(this.SetActiveButton);
            SavesTab.Controls.Add(RenameButton);
            SavesTab.Controls.Add(this.SaveList);
            SavesTab.Controls.Add(CreateButton);
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
            DeleteButton.Location = new System.Drawing.Point(362, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(75, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            RenameButton.Location = new System.Drawing.Point(281, 3);
            RenameButton.Name = "RenameButton";
            RenameButton.Size = new System.Drawing.Size(75, 23);
            RenameButton.TabIndex = 4;
            RenameButton.Text = "Rename";
            RenameButton.UseVisualStyleBackColor = true;
            RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // SaveList
            // 
            this.SaveList.FormattingEnabled = true;
            this.SaveList.Location = new System.Drawing.Point(3, 32);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(434, 381);
            this.SaveList.TabIndex = 1;
            this.SaveList.SelectedIndexChanged += new System.EventHandler(this.SaveList_SelectIndexChanged);
            // 
            // CreateButton
            // 
            CreateButton.Location = new System.Drawing.Point(200, 3);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new System.Drawing.Size(75, 23);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
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
            BackupsTab.Controls.Add(BackupAllButton);
            BackupsTab.Controls.Add(bckpSetActiveButton);
            BackupsTab.Controls.Add(BackupDeleteButton);
            BackupsTab.Controls.Add(BackupsBox);
            BackupsTab.Controls.Add(SavesBox);
            BackupsTab.Controls.Add(BackupButton);
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
            BackupAllButton.Location = new System.Drawing.Point(84, 3);
            BackupAllButton.Name = "BackupAllButton";
            BackupAllButton.Size = new System.Drawing.Size(75, 23);
            BackupAllButton.TabIndex = 8;
            BackupAllButton.Text = "Backup All";
            BackupAllButton.UseVisualStyleBackColor = true;
            BackupAllButton.Click += new System.EventHandler(this.BackupAllButton_Click);
            // 
            // bckpSetActiveButton
            // 
            bckpSetActiveButton.Enabled = false;
            bckpSetActiveButton.Location = new System.Drawing.Point(246, 3);
            bckpSetActiveButton.Name = "bckpSetActiveButton";
            bckpSetActiveButton.Size = new System.Drawing.Size(75, 23);
            bckpSetActiveButton.TabIndex = 7;
            bckpSetActiveButton.Text = "Set Active";
            this.toolTip1.SetToolTip(bckpSetActiveButton, "Stores active save and loads backup into active.");
            bckpSetActiveButton.UseVisualStyleBackColor = true;
            // 
            // BackupDeleteButton
            // 
            BackupDeleteButton.Location = new System.Drawing.Point(165, 3);
            BackupDeleteButton.Name = "BackupDeleteButton";
            BackupDeleteButton.Size = new System.Drawing.Size(75, 23);
            BackupDeleteButton.TabIndex = 6;
            BackupDeleteButton.Text = "Delete";
            BackupDeleteButton.UseVisualStyleBackColor = true;
            BackupDeleteButton.Click += new System.EventHandler(this.BackupDeleteButton_Click);
            // 
            // BackupsBox
            // 
            BackupsBox.Controls.Add(this.BackupList);
            BackupsBox.Location = new System.Drawing.Point(227, 29);
            BackupsBox.Name = "BackupsBox";
            BackupsBox.Size = new System.Drawing.Size(223, 390);
            BackupsBox.TabIndex = 5;
            BackupsBox.TabStop = false;
            BackupsBox.Text = "Backups";
            // 
            // BackupList
            // 
            this.BackupList.FormattingEnabled = true;
            this.BackupList.Location = new System.Drawing.Point(6, 15);
            this.BackupList.Name = "BackupList";
            this.BackupList.Size = new System.Drawing.Size(211, 368);
            this.BackupList.TabIndex = 2;
            // 
            // SavesBox
            // 
            SavesBox.Controls.Add(this.BckpSaveList);
            SavesBox.Location = new System.Drawing.Point(3, 29);
            SavesBox.Name = "SavesBox";
            SavesBox.Size = new System.Drawing.Size(223, 390);
            SavesBox.TabIndex = 4;
            SavesBox.TabStop = false;
            SavesBox.Text = "Saves";
            // 
            // BckpSaveList
            // 
            this.BckpSaveList.FormattingEnabled = true;
            this.BckpSaveList.Location = new System.Drawing.Point(6, 15);
            this.BckpSaveList.Name = "BckpSaveList";
            this.BckpSaveList.Size = new System.Drawing.Size(211, 368);
            this.BckpSaveList.TabIndex = 2;
            // 
            // BackupButton
            // 
            BackupButton.Location = new System.Drawing.Point(3, 3);
            BackupButton.Name = "BackupButton";
            BackupButton.Size = new System.Drawing.Size(75, 23);
            BackupButton.TabIndex = 3;
            BackupButton.Text = "Backup";
            BackupButton.UseVisualStyleBackColor = true;
            BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // SettingsTab
            // 
            SettingsTab.Controls.Add(OptionsBox);
            SettingsTab.Controls.Add(ExperimentalBox);
            SettingsTab.Location = new System.Drawing.Point(4, 22);
            SettingsTab.Name = "SettingsTab";
            SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            SettingsTab.Size = new System.Drawing.Size(456, 422);
            SettingsTab.TabIndex = 1;
            SettingsTab.Text = "Settings";
            SettingsTab.UseVisualStyleBackColor = true;
            // 
            // OptionsBox
            // 
            OptionsBox.Controls.Add(this.SetStoreLocationButton);
            OptionsBox.Location = new System.Drawing.Point(3, 6);
            OptionsBox.Name = "OptionsBox";
            OptionsBox.Size = new System.Drawing.Size(223, 409);
            OptionsBox.TabIndex = 8;
            OptionsBox.TabStop = false;
            OptionsBox.Text = "Options";
            // 
            // SetStoreLocationButton
            // 
            this.SetStoreLocationButton.Location = new System.Drawing.Point(6, 19);
            this.SetStoreLocationButton.Name = "SetStoreLocationButton";
            this.SetStoreLocationButton.Size = new System.Drawing.Size(105, 23);
            this.SetStoreLocationButton.TabIndex = 0;
            this.SetStoreLocationButton.Text = "Set store location";
            this.toolTip1.SetToolTip(this.SetStoreLocationButton, "Change where inactives saves are kept.");
            this.SetStoreLocationButton.UseVisualStyleBackColor = true;
            this.SetStoreLocationButton.Click += new System.EventHandler(this.SetStoreLocationButton_Click);
            // 
            // ExperimentalBox
            // 
            ExperimentalBox.Controls.Add(this.KeepPopulationBox);
            ExperimentalBox.Controls.Add(this.KeepSettingsBox);
            ExperimentalBox.Controls.Add(this.KeepDogBox);
            ExperimentalBox.Controls.Add(this.KeepAchievesBox);
            ExperimentalBox.Controls.Add(this.KeepNeedZBox);
            ExperimentalBox.Controls.Add(this.KeepFOWBox);
            ExperimentalBox.Controls.Add(this.KeepIconsBox);
            ExperimentalBox.Location = new System.Drawing.Point(227, 6);
            ExperimentalBox.Name = "ExperimentalBox";
            ExperimentalBox.Size = new System.Drawing.Size(223, 409);
            ExperimentalBox.TabIndex = 7;
            ExperimentalBox.TabStop = false;
            ExperimentalBox.Text = "Experimental";
            // 
            // KeepPopulationBox
            // 
            this.KeepPopulationBox.AutoSize = true;
            this.KeepPopulationBox.Location = new System.Drawing.Point(5, 157);
            this.KeepPopulationBox.Name = "KeepPopulationBox";
            this.KeepPopulationBox.Size = new System.Drawing.Size(136, 17);
            this.KeepPopulationBox.TabIndex = 7;
            this.KeepPopulationBox.Text = "Keep animal population";
            this.toolTip1.SetToolTip(this.KeepPopulationBox, "Preserves dog progress.");
            this.KeepPopulationBox.UseVisualStyleBackColor = true;
            // 
            // KeepSettingsBox
            // 
            this.KeepSettingsBox.AutoSize = true;
            this.KeepSettingsBox.Location = new System.Drawing.Point(6, 19);
            this.KeepSettingsBox.Name = "KeepSettingsBox";
            this.KeepSettingsBox.Size = new System.Drawing.Size(90, 17);
            this.KeepSettingsBox.TabIndex = 1;
            this.KeepSettingsBox.Text = "Keep settings";
            this.toolTip1.SetToolTip(this.KeepSettingsBox, "Preserves in game settings and keybindings.");
            this.KeepSettingsBox.UseVisualStyleBackColor = true;
            this.KeepSettingsBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // KeepDogBox
            // 
            this.KeepDogBox.AutoSize = true;
            this.KeepDogBox.Location = new System.Drawing.Point(6, 134);
            this.KeepDogBox.Name = "KeepDogBox";
            this.KeepDogBox.Size = new System.Drawing.Size(103, 17);
            this.KeepDogBox.TabIndex = 6;
            this.KeepDogBox.Text = "Keep dog profile";
            this.toolTip1.SetToolTip(this.KeepDogBox, "Preserves dog progress.");
            this.KeepDogBox.UseVisualStyleBackColor = true;
            this.KeepDogBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // KeepAchievesBox
            // 
            this.KeepAchievesBox.AutoSize = true;
            this.KeepAchievesBox.Location = new System.Drawing.Point(6, 42);
            this.KeepAchievesBox.Name = "KeepAchievesBox";
            this.KeepAchievesBox.Size = new System.Drawing.Size(120, 17);
            this.KeepAchievesBox.TabIndex = 2;
            this.KeepAchievesBox.Text = "Keep achievements";
            this.toolTip1.SetToolTip(this.KeepAchievesBox, "Preserves achievements and mission data.");
            this.KeepAchievesBox.UseVisualStyleBackColor = true;
            this.KeepAchievesBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // KeepNeedZBox
            // 
            this.KeepNeedZBox.AutoSize = true;
            this.KeepNeedZBox.Location = new System.Drawing.Point(6, 111);
            this.KeepNeedZBox.Name = "KeepNeedZBox";
            this.KeepNeedZBox.Size = new System.Drawing.Size(109, 17);
            this.KeepNeedZBox.TabIndex = 5;
            this.KeepNeedZBox.Text = "Keep need zones";
            this.toolTip1.SetToolTip(this.KeepNeedZBox, "Preserves found need zones.");
            this.KeepNeedZBox.UseVisualStyleBackColor = true;
            this.KeepNeedZBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // KeepFOWBox
            // 
            this.KeepFOWBox.AutoSize = true;
            this.KeepFOWBox.Location = new System.Drawing.Point(6, 65);
            this.KeepFOWBox.Name = "KeepFOWBox";
            this.KeepFOWBox.Size = new System.Drawing.Size(79, 17);
            this.KeepFOWBox.TabIndex = 3;
            this.KeepFOWBox.Text = "Keep FOW";
            this.toolTip1.SetToolTip(this.KeepFOWBox, "Preserves fog of war, the lighter (explored) areas of the map.");
            this.KeepFOWBox.UseVisualStyleBackColor = true;
            this.KeepFOWBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // KeepIconsBox
            // 
            this.KeepIconsBox.AutoSize = true;
            this.KeepIconsBox.Location = new System.Drawing.Point(6, 88);
            this.KeepIconsBox.Name = "KeepIconsBox";
            this.KeepIconsBox.Size = new System.Drawing.Size(79, 17);
            this.KeepIconsBox.TabIndex = 4;
            this.KeepIconsBox.Text = "Keep icons";
            this.toolTip1.SetToolTip(this.KeepIconsBox, "Preserves found outposts, hunting stands, landmarks, etc.");
            this.KeepIconsBox.UseVisualStyleBackColor = true;
            this.KeepIconsBox.CheckedChanged += new System.EventHandler(this.OnCopySettingsChange);
            // 
            // MiscTab
            // 
            this.MiscTab.Controls.Add(this.ReportBugButtom);
            this.MiscTab.Controls.Add(this.ChkUpdateButton);
            this.MiscTab.Controls.Add(this.VersionLabel);
            this.MiscTab.Location = new System.Drawing.Point(4, 22);
            this.MiscTab.Name = "MiscTab";
            this.MiscTab.Size = new System.Drawing.Size(456, 422);
            this.MiscTab.TabIndex = 3;
            this.MiscTab.Text = "Misc";
            this.MiscTab.UseVisualStyleBackColor = true;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(5, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(75, 13);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "Version: X.X.X";
            // 
            // ChkUpdateButton
            // 
            this.ChkUpdateButton.Location = new System.Drawing.Point(8, 26);
            this.ChkUpdateButton.Name = "ChkUpdateButton";
            this.ChkUpdateButton.Size = new System.Drawing.Size(105, 23);
            this.ChkUpdateButton.TabIndex = 1;
            this.ChkUpdateButton.Text = "Check for updates";
            this.ChkUpdateButton.UseVisualStyleBackColor = true;
            this.ChkUpdateButton.Click += new System.EventHandler(this.CheckForUpdatesButton_Click);
            // 
            // ReportBugButtom
            // 
            this.ReportBugButtom.Location = new System.Drawing.Point(8, 55);
            this.ReportBugButtom.Name = "ReportBugButtom";
            this.ReportBugButtom.Size = new System.Drawing.Size(75, 23);
            this.ReportBugButtom.TabIndex = 2;
            this.ReportBugButtom.Text = "Report Bug";
            this.ReportBugButtom.UseVisualStyleBackColor = true;
            this.ReportBugButtom.Click += new System.EventHandler(this.ReportBugButton_Click);
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
            OptionsBox.ResumeLayout(false);
            ExperimentalBox.ResumeLayout(false);
            ExperimentalBox.PerformLayout();
            this.MiscTab.ResumeLayout(false);
            this.MiscTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetActiveButton;
        private System.Windows.Forms.ListBox SaveList;
        private System.Windows.Forms.TextBox SaveNameInput;
        private System.Windows.Forms.CheckBox KeepAchievesBox;
        private System.Windows.Forms.CheckBox KeepSettingsBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox KeepFOWBox;
        private System.Windows.Forms.CheckBox KeepIconsBox;
        private System.Windows.Forms.CheckBox KeepNeedZBox;
        private System.Windows.Forms.CheckBox KeepDogBox;
        private System.Windows.Forms.Button SetStoreLocationButton;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.ListBox BckpSaveList;
        private System.Windows.Forms.ListBox BackupList;
        private System.Windows.Forms.CheckBox KeepPopulationBox;
        private System.Windows.Forms.TabPage MiscTab;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button ChkUpdateButton;
        private System.Windows.Forms.Button ReportBugButtom;
    }
}


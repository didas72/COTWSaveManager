using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Net;

using COTWSaveManager.Properties;

namespace COTWSaveManager
{
    public partial class MainForm : Form
    {
        public bool KeepSettings { get => KeepSettingsBox.Checked; set => KeepSettingsBox.Checked = value; }
        public bool KeepAchieves { get => KeepAchievesBox.Checked; set => KeepAchievesBox.Checked = value; }
        public bool KeepFOW { get => KeepFOWBox.Checked; set => KeepFOWBox.Checked = value; }
        public bool KeepIcons { get => KeepIconsBox.Checked; set => KeepIconsBox.Checked = value; }
        public bool KeepNeedZ { get => KeepNeedZBox.Checked; set => KeepNeedZBox.Checked = value; }
        public bool KeepDog { get => KeepDogBox.Checked; set => KeepDogBox.Checked = value; }
        public bool KeepPopulation { get => KeepPopulationBox.Checked; set => KeepPopulationBox.Checked = value; }



        public MainForm()
        {
            InitializeComponent();
        }



        //Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveHelper.InitSettings(this);
            UpdateSaveLists();
            UpdateBackupList();
            UpdateVersionLabel();
        }


        #region Tabs
        #region Saves
        private void SetActiveButton_Click(object sender, EventArgs e)
        {
            if (SaveList.SelectedIndex < 0 || SaveList.SelectedIndex >= SaveList.Items.Count)
            {
                MessageBox.Show("Please select a save to set as active.", "No save selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (SaveList.SelectedIndex == 0)
            {
                CopyActiveButton_Click(sender, e);
                return;
            }

            int index = SaveList.SelectedIndex;
            string saveName = (string)SaveList.Items[index];
            SaveHelper.StoreActiveSave();
            SaveHelper.ActivateStoredSave(saveName);

            UpdateSaveLists();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be emtpy.", "Empty save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (SaveNameInput.Text == Settings.Default.activeSave ||
                Directory.GetFiles(Settings.Default.storePath, "*.zip")
                .Any((string path) => Path.GetFileNameWithoutExtension(path) == SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be repeated.", "Repeated save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SaveHelper.AddNewSaveWithCopy(SaveNameInput.Text);
            UpdateSaveLists();

            if (SaveHelper.KeepAny())
                MessageBox.Show("New save created successfully.\nSome files were kept. Just press 'Continue' or 'Change Reserve' to play.",
                    "Launch theHunter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("New save created successfully.\nPlease launch theHunter and click 'New Game' to initialize save files.",
                    "Launch theHunter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (SaveList.SelectedIndex < 0 || SaveList.SelectedIndex >= SaveList.Items.Count)
            {
                MessageBox.Show("Please select a save to set as active.", "No save selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (string.IsNullOrWhiteSpace(SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be emtpy.", "Empty save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (SaveNameInput.Text == Settings.Default.activeSave ||
                Directory.GetFiles(Settings.Default.storePath, "*.zip")
                .Any((string path) => Path.GetFileNameWithoutExtension(path) == SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be repeated.", "Repeated save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            if (SaveList.SelectedIndex == 0)
                SaveHelper.RenameActiveSave(SaveNameInput.Text);
            else
                SaveHelper.RenameStoredSave((string)SaveList.Items[SaveList.SelectedIndex], SaveNameInput.Text);

            UpdateSaveLists();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SaveList.SelectedIndex < 0 || SaveList.SelectedIndex >= SaveList.Items.Count)
            {
                MessageBox.Show("Please select a save to delete.", "No save selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (SaveList.SelectedIndex == 0)
            {
                MessageBox.Show("Cannot delete currently active save.", "Cannot delete save",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            string saveName = (string)SaveList.Items[SaveList.SelectedIndex];
            DialogResult res = MessageBox.Show($"Once deleted, saves CANNOT be recovered.\nAre you sure you want to delete save '{saveName}'?", "Confirm delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.No)
                return;

            if (res == DialogResult.Yes)
            { 
                SaveHelper.DeleteStoredSave(saveName);
                UpdateSaveLists();
            }
        }

        private void SaveList_SelectIndexChanged(object sender, EventArgs e)
        {
            SetActiveButton.Text = SaveList.SelectedIndex == 0 ? "Copy Active" : "Set Active";
        }

        //Multiplexed with SetActive, call in SetActive handle
        private void CopyActiveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be emtpy.", "Empty save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (SaveNameInput.Text == Settings.Default.activeSave ||
                Directory.GetFiles(Settings.Default.storePath, "*.zip")
                .Any((string path) => Path.GetFileNameWithoutExtension(path) == SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be repeated.", "Repeated save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SaveHelper.StoreActiveSave();
            SaveHelper.CloneStoredSave(Settings.Default.activeSave);

            Settings.Default.activeSave = SaveNameInput.Text;
            Settings.Default.Save();

            UpdateSaveLists();
        }
        #endregion

        #region Backups
        private void BackupButton_Click(object sender, EventArgs e)
        {
            if (BckpSaveList.SelectedIndex < 0 || BckpSaveList.SelectedIndex >= BckpSaveList.Items.Count)
            {
                MessageBox.Show("Please select a save to backup.", "No save selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (BckpSaveList.SelectedIndex == 0)
                SaveHelper.BackupActiveSave();
            else
                SaveHelper.BackupInactiveSave((string)BckpSaveList.Items[BckpSaveList.SelectedIndex]);

            UpdateBackupList();
        }
        private void BackupAllButton_Click(object sender, EventArgs e)
        {
            SaveHelper.BackupAllSaves();

            UpdateBackupList();
        }
        private void BackupDeleteButton_Click(object sender, EventArgs e)
        {
            if (BackupList.SelectedIndex < 0 || BackupList.SelectedIndex >= BackupList.Items.Count)
            {
                MessageBox.Show("Please select a backup to delete.", "No backup selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            SaveHelper.DeleteBackup((string)BackupList.Items[BackupList.SelectedIndex]);

            UpdateBackupList();
        }
        private void BackupExportButton_Click(object sender, EventArgs e)
        {
            if (BckpSaveList.SelectedIndex < 0 || BckpSaveList.SelectedIndex >= BckpSaveList.Items.Count)
            {
                MessageBox.Show("Please select a save to export.", "No save selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            string filePath;

            if (BckpSaveList.SelectedIndex == 0)
                filePath = SaveHelper.ExportActiveSave();
            else
                filePath = SaveHelper.ExportInactiveSave((string)BckpSaveList.Items[BckpSaveList.SelectedIndex]);

            DialogResult res = MessageBox.Show("Save exported successfully. Show exported file?", "Export successful", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
                Process.Start("explorer.exe", $"/select,\"{filePath}\"");
        }
        private void BackupImportButton_Click(object sender, EventArgs e)
        {
            openFileDialog.CheckPathExists = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "*.zip";
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            SaveHelper.ImportSave(openFileDialog.FileName);

            MessageBox.Show("Save imported successfully.", "Import successful", MessageBoxButtons.OK);

            UpdateBackupList();
        }
        #endregion

        #region Settings
        private void OnCopySettingsChange(object sender, EventArgs e)
        {
            SaveHelper.UpdateCopySettings(this);
        }

        private void SetStoreLocationButton_Click(object sender, EventArgs e)
        {
            folderDialog.SelectedPath = Settings.Default.storePath;
            folderDialog.ShowNewFolderButton = true;
            folderDialog.Description = "Select folder to store inactive saves.";
            DialogResult result = folderDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            try
            {
                if (!Directory.Exists(folderDialog.SelectedPath)) 
                    throw new Exception(); //Just pass it down to the catch part
            }
            catch
            {
                MessageBox.Show("Could not find the selected folder. Make sure the folder is created.", "Invalid folder", MessageBoxButtons.OK);
            }

            if (folderDialog.SelectedPath == Settings.Default.storePath)
                return;

            if (!Utils.HasDirectoryAccess(folderDialog.SelectedPath))
            {
                MessageBox.Show("Unable to write to selected folder. Make sure your user has access to the folder.", "Insuficcient permissions", MessageBoxButtons.OK);
                return;
            }    

            SaveHelper.MoveStoreDir(folderDialog.SelectedPath);
        }
        #endregion

        #region Misc
        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/didas72/COTWSaveManager/issues");
        }

        private void CheckForUpdatesButton_Click(object sender, EventArgs e)
        {
            WebClient cli = new WebClient();
            string apiResp;

            try
            {
                cli.Headers.Add("User-Agent: Other");
                apiResp = cli.DownloadString("https://api.github.com/repos/didas72/COTWSaveManager/releases/latest"); //TODO: Async maybe
            }
            catch
            {
                MessageBox.Show("Could not connect to github.", "Update check error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (apiResp == null)
            {
                MessageBox.Show("Failed to get version information.", "Update check error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string versionStr = FindTagNameInJsonRoot(apiResp);

            if (versionStr == null)
            {
                MessageBox.Show("Could not parse latest version.", "Update check error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Version latestVersion = Version.Parse(versionStr);
            Version selfVersion = Assembly.GetExecutingAssembly().GetName().Version;

            if (selfVersion.CompareTo(latestVersion) != -1)
            {
                MessageBox.Show("Latest version installed!", "Update check",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult res =MessageBox.Show("Newer version available. Open Nexus mod page?", "Update available",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                    Process.Start("explorer.exe", "https://www.nexusmods.com/thehuntercallofthewild/mods/268");

                return;
            }
        }
        #endregion
        #endregion



        //Aux
        private void UpdateSaveLists()
        {
            string[] saveStrings = SaveHelper.GetSaveList();
            SaveList.Items.Clear();
            SaveList.Items.AddRange(saveStrings);
            BckpSaveList.Items.Clear();
            BckpSaveList.Items.AddRange(saveStrings);
        }
        private void UpdateBackupList()
        {
            BackupList.Items.Clear();
            BackupList.Items.AddRange(SaveHelper.GetBackupList());
        }
        private void UpdateVersionLabel()
        {
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            VersionLabel.Text = $"Version: {v}";
        }
        private string FindTagNameInJsonRoot(string json)
        {
            int depth = 0;
            string lastStr = null;
            bool lastStrTag = false;

            for (int i = 0; i < json.Length; i++)
            {
                if (json[i] == '{')
                    depth++;
                else if (json[i] == '}')
                    depth--;
                else if (depth != 1)
                    continue; //only search in root

                //TODO: Not ignore security problems :)
                if (json[i] == '"') //assume json properly formatted 
                {
                    if (lastStr == "tag_name")
                        lastStrTag = true;

                    int closeIndex = json.IndexOf('"', i + 1);
                    lastStr = json.Substring(i + 1, closeIndex - i - 1);

                    if (lastStrTag) return lastStr; //TODO: Test

                    i = closeIndex; continue;
                }
            }

            return null;
        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using COTWSaveManager.Properties;

namespace COTWSaveManager
{
    public partial class MainForm : Form
    {
        public bool KeepSettings { get => keepSettingsBox.Checked; set => keepSettingsBox.Checked = value; }
        public bool KeepAchieves { get => keepAchievesBox.Checked; set => keepAchievesBox.Checked = value; }
        public bool KeepFOW { get => keepFOWBox.Checked; set => keepFOWBox.Checked = value; }
        public bool KeepIcons { get => keepIconsBox.Checked; set => keepIconsBox.Checked = value; }
        public bool KeepNeedZ { get => keepNeedZBox.Checked; set => keepNeedZBox.Checked = value; }
        public bool KeepDog { get => keepDogBox.Checked; set => keepDogBox.Checked = value; }



        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveHelper.InitSettings(this);
            UpdateSaveList();
        }

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
                MessageBox.Show("The selected save is already active.", "Save already active",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            int index = SaveList.SelectedIndex;
            string saveName = (string)SaveList.Items[index];
            SaveHelper.StoreActiveSave();
            SaveHelper.ActivateStoredSave(saveName);

            UpdateSaveList();
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
            UpdateSaveList();


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

            UpdateSaveList();
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
                UpdateSaveList();
            }
        }



        private void OnCopySettingsChange(object sender, EventArgs e)
        {
            SaveHelper.UpdateCopySettings(this);
        }



        private void UpdateSaveList()
        {
            SaveList.Items.Clear();
            SaveList.Items.AddRange(SaveHelper.GetSaveList());
        }
    }
}

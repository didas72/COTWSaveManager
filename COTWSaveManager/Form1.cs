using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace COTWSaveManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveHelper.InitSettings();
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
            if (SaveNameInput.Text == Properties.Settings.Default.activeSave ||
                Directory.GetFiles(Properties.Settings.Default.storePath, "*.zip")
                .Any((string path) => Path.GetFileNameWithoutExtension(path) == SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be repeated.", "Repeated save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SaveHelper.StoreActiveSave();
            Properties.Settings.Default.activeSave = SaveNameInput.Text;
            Properties.Settings.Default.Save();
            UpdateSaveList();

            MessageBox.Show("This program cannot generate the save files on it's own.\nPlease launch theHunter to create the save files.",
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
            if (SaveNameInput.Text == Properties.Settings.Default.activeSave ||
                Directory.GetFiles(Properties.Settings.Default.storePath, "*.zip")
                .Any((string path) => Path.GetFileNameWithoutExtension(path) == SaveNameInput.Text))
            {
                MessageBox.Show("Save name cannot be repeated.", "Repeated save name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            if (SaveList.SelectedIndex == 0)
            {
                Properties.Settings.Default.activeSave = SaveNameInput.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                File.Move(Path.Combine(Properties.Settings.Default.storePath, (string)SaveList.Items[SaveList.SelectedIndex] + ".zip"),
                        Path.Combine(Properties.Settings.Default.storePath, SaveNameInput.Text + ".zip"));
            }

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




        private void UpdateSaveList()
        {
            SaveList.Items.Clear();
            SaveList.Items.AddRange(SaveHelper.GetSaveList());
        }
    }
}

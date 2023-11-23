using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

using COTWSaveManager.Properties;

namespace COTWSaveManager
{
    internal static class SaveHelper
    {
        private static bool finishedInit = false;



        public static void InitSettings(MainForm caller)
        {
            InitSaveName();
            InitBasePath();
            InitStoreDir();

            Settings.Default.Save();

            InitCopySettings(caller);

            finishedInit = true;
        }
        private static void InitSaveName()
        {
            if (!string.IsNullOrEmpty(Settings.Default.activeSave))
                return;

            Settings.Default.activeSave = "Unnamed save";
        }
        private static void InitBasePath()
        {
            if (!string.IsNullOrEmpty(Settings.Default.saveBasePath))
                return;

            //Determine save path
            string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Avalanche Studios");

            if (!Directory.Exists(basePath))
            {
                MessageBox.Show("Make sure the folder 'Avalanche Studios' exists in your documents.", "Could not find save folder.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //TODO: Replace exit with prompt to select folder
                Application.Exit();
            }

            if (Directory.Exists(Path.Combine(basePath, "Epic Games Store")))
                basePath = Path.Combine(basePath, "Epic Games Store");

            Settings.Default.saveBasePath = basePath;
        }
        private static void InitStoreDir()
        {
            if (string.IsNullOrEmpty(Settings.Default.storePath))
                Settings.Default.storePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "COTWSaveManager");

            Directory.CreateDirectory(Settings.Default.storePath);
            Directory.CreateDirectory(Path.Combine(Settings.Default.storePath, "backups"));
        }
        private static void InitCopySettings(MainForm caller)
        {
            caller.KeepSettings = Settings.Default.keepSettings;
            caller.KeepAchieves = Settings.Default.keepAchieves;
            caller.KeepFOW = Settings.Default.keepFOW;
            caller.KeepIcons = Settings.Default.keepIcons;
            caller.KeepNeedZ = Settings.Default.keepNeedZ;
            caller.KeepDog = Settings.Default.keepDog;
            caller.KeepPopulation = Settings.Default.keepPopulation;
        }



        //Lists
        public static string[] GetSaveList()
        {
            List<string> ret = new List<string>
            {
                "[ACTIVE] " + Settings.Default.activeSave
            };

            foreach (string path in Directory.GetFiles(Settings.Default.storePath, "*.zip"))
                ret.Add(Path.GetFileNameWithoutExtension(path));

            return ret.ToArray();
        }



        //Saves
        public static void StoreActiveSave()
        {
            string dest = Path.Combine(Settings.Default.storePath, Settings.Default.activeSave + ".zip");

            ZipFile.CreateFromDirectory(Settings.Default.saveBasePath, dest, CompressionLevel.Fastest, false, Encoding.Default);

            Directory.Delete(Settings.Default.saveBasePath, true);
            Directory.CreateDirectory(Settings.Default.saveBasePath);
        }
        public static void StoreActiveCopy()
        {
            string dest = Path.Combine(Settings.Default.storePath, Settings.Default.activeSave + ".zip");

            ZipFile.CreateFromDirectory(Settings.Default.saveBasePath, dest, CompressionLevel.Fastest, false, Encoding.Default);

            Directory.CreateDirectory(Settings.Default.saveBasePath);
        }
        public static void ActivateStoredSave(string saveName)
        {
            string src = Path.Combine(Settings.Default.storePath, saveName + ".zip");

            ZipFile.ExtractToDirectory(src, Settings.Default.saveBasePath, Encoding.Default);

            File.Delete(src);

            Settings.Default.activeSave = saveName;
            Settings.Default.Save();
        }
        public static void CloneStoredSave(string saveName)
        {
            string src = Path.Combine(Settings.Default.storePath, saveName + ".zip");

            ZipFile.ExtractToDirectory(src, Settings.Default.saveBasePath, Encoding.Default);

            Settings.Default.activeSave = saveName;
            Settings.Default.Save();
        }
        public static void DeleteStoredSave(string saveName)
        {
            string src = Path.Combine(Settings.Default.storePath, saveName + ".zip");

            File.Delete(src);
        }
        public static void RenameActiveSave(string newName)
        {
            Settings.Default.activeSave = newName;
            Settings.Default.Save();
        }
        public static void RenameStoredSave(string oldName, string newName)
        {
            File.Move(Path.Combine(Settings.Default.storePath, oldName + ".zip"),
                        Path.Combine(Settings.Default.storePath, newName + ".zip"));
        }
        public static void AddNewSaveWithCopy(string newName)
        {
            StoreActiveCopy();
            Settings.Default.activeSave = newName;
            Settings.Default.Save();

            string path = Settings.Default.saveBasePath, lPath;

            //TODO: Remove, commented for testing
            /*if (!KeepAny())
            {
                Directory.Delete(path, true);
                return; 
            }*/

            lPath = Path.Combine(path, "theHunter Call of the Wild");

            if (!Settings.Default.keepSettings)
            {
                if (Directory.Exists(lPath)) Directory.Delete(lPath, true);
            }

                path = Path.Combine(path, "COTW");
            if (!Directory.Exists(path))
                return;
            path = Path.Combine(path, "Saves");
            if (!Directory.Exists(path))
                return;

            string[] paths = Directory.GetDirectories(path);

            if (paths.Length == 0) return;
            if (paths.Length != 1) return; //FIXME: Error out

            path = paths[0];

            if (!Settings.Default.keepSettings)
            {
                File.Delete(Path.Combine(path, "settings_adf"));
            }

            if (!Settings.Default.keepAchieves)
            {
                lPath = Path.Combine(path, "achievements_adf"); if (File.Exists(lPath)) File.Delete(lPath);
                lPath = Path.Combine(path, "achievements_progress_missiondata_adf"); if (File.Exists(lPath)) File.Delete(lPath);
                lPath = Path.Combine(path, "missions_missiondata_adf"); if (File.Exists(lPath)) File.Delete(lPath);
            }

            if (!Settings.Default.keepFOW)
            {
                paths = Directory.GetFiles(path, "adf_fog_of_war_data_faster_*");
                foreach (string s in paths)
                    File.Delete(s);
            }

            if (!Settings.Default.keepIcons)
            {
                paths = Directory.GetFiles(path, "found_icons_*");
                foreach (string s in paths)
                    File.Delete(s);
            }

            if (!Settings.Default.keepNeedZ)
            {
                lPath = Path.Combine(path, "found_need_zones_adf"); if (File.Exists(lPath)) File.Delete(lPath);
            }

            if (!Settings.Default.keepDog)
            {
                lPath = Path.Combine(path, "thp_dog_profile_adf"); if (File.Exists(lPath)) File.Delete(lPath);
            }

            if (!Settings.Default.keepPopulation)
            {
                paths = Directory.GetFiles(path, "animal_population_*");
                foreach (string s in paths)
                    File.Delete(s);
            }

            DeleteNoCopyFiles(path);
        }



        //Settings
        public static void UpdateCopySettings(MainForm caller)
        {
            if (!finishedInit)
                return;


            if (!Settings.Default.experimentalWarnShown)
            {
                MessageBox.Show("Keeping of previous progress is an experimental feature. It may fail or perform in an unexpected way. Please report any bugs found.",
                    "Launch theHunter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Settings.Default.experimentalWarnShown = true;
            }

            Settings.Default.keepSettings = caller.KeepSettings;
            Settings.Default.keepAchieves = caller.KeepAchieves;
            Settings.Default.keepFOW = caller.KeepFOW;
            Settings.Default.keepIcons = caller.KeepIcons;
            Settings.Default.keepNeedZ = caller.KeepNeedZ;
            Settings.Default.keepDog = caller.KeepDog;
            Settings.Default.keepPopulation = caller.KeepPopulation;

            Settings.Default.Save();
        }
        public static void MoveStoreDir(string newPath)
        {
            Utils.MoveDirectoryRecursive(Settings.Default.storePath, newPath);

            Settings.Default.storePath = newPath;
            Settings.Default.Save();
        }



        //Backups
        public static string[] GetBackupList()
        {
            List<string> ret = new List<string>();

            foreach (string path in Directory.GetFiles(Path.Combine(Settings.Default.storePath, "backups"), "*.zip"))
                ret.Add(Path.GetFileNameWithoutExtension(path));

            return ret.ToArray();
        }
        public static void BackupActiveSave()
        {
            string dest = Path.Combine(Settings.Default.storePath, "backups",
                Settings.Default.activeSave + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss") + ".zip");

            ZipFile.CreateFromDirectory(Settings.Default.saveBasePath, dest, CompressionLevel.Fastest, false, Encoding.Default);
        }
        public static void BackupInactiveSave(string saveName)
        {
            string src = Path.Combine(Settings.Default.storePath, saveName + ".zip");
            string dest = Path.Combine(Settings.Default.storePath, "backups",
                saveName + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss") + ".zip");

            File.Copy(src, dest);
        }
        public static void BackupAllSaves()
        {
            BackupActiveSave();

            foreach (string s in Directory.GetFiles(Settings.Default.storePath, "*.zip"))
            {
                string saveName = Path.GetFileNameWithoutExtension(s);
                string dest = Path.Combine(Settings.Default.storePath, "backups",
                    saveName + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss") + ".zip");
                File.Copy(s, dest);
            }
        }
        public static void DeleteBackup(string backupName)
        {
            string src = Path.Combine(Settings.Default.storePath, "backups", backupName + ".zip");

            File.Delete(src);
        }
        /*public static void RevertToBackup(string backupName)
        {

        }*/
        public static string ExportActiveSave()
        {
            string dest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                Settings.Default.activeSave + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss") + ".zip");

            ZipFile.CreateFromDirectory(Settings.Default.saveBasePath, dest, CompressionLevel.Fastest, false, Encoding.Default);

            return dest;
        }
        public static string ExportInactiveSave(string saveName)
        {
            string src = Path.Combine(Settings.Default.storePath, saveName + ".zip");
            string dest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                saveName + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss") + ".zip");

            File.Copy(src, dest);

            return dest;
        }
        public static void ImportSave(string src)
        {
            string dest = Path.Combine(Settings.Default.storePath, Path.GetFileName(src));

            File.Copy(src, dest);
        }



        public static bool KeepAny()
        {
            return Settings.Default.keepAchieves || Settings.Default.keepDog || Settings.Default.keepFOW ||
                Settings.Default.keepIcons || Settings.Default.keepNeedZ || Settings.Default.keepSettings ||
                Settings.Default.keepPopulation;
        }
        private static void DeleteNoCopyFiles(string path)
        {
            /*Always preserve files:
            * ===Trying to skip license===
            * --socialconfig
            * --statistics_adf
            * playerinformation_adf (Allows skipping license)
            * ===Trying to skip 'New Game'===
            * --socialconfig
            * --statistics_adf
            * --reserveworlddata_adf
            * --regions_adf
            * thp_player_profile_adf (Allows not creating new game)
            */

            string[] patterns = new string[] { 
                "apex_notifications_adf", "codex_seen_status_adf", "collectibles_adf", "contextual_help_adf",
                "hunting_log_adf", "leaderboard_adf", "regions_adf", "reserveworlddata_adf",
                "socialconfig", "statistics_adf", "trophy_lodges_adf", "worlditemsdata_adf"
            };

            string lPath = Path.Combine(path, "slots");

            if (Directory.Exists(lPath)) Directory.Delete(lPath, true);

            foreach (string p in patterns)
                foreach (string s in Directory.GetFiles(path, p))
                    File.Delete(s);
        }
    }
}

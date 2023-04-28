using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COTWSaveManager
{
    internal static class SaveHelper
    {
        public static void InitSettings()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.storePath)) //Already initted
                return;

            InitBasePath();
            InitStoreDir();
            Properties.Settings.Default.activeSave = "Unnamed save";

            Properties.Settings.Default.Save();
        }
        private static void InitBasePath()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.saveBasePath))
            {
                //Determine save path
                string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Avalanche Studios");

                if (!Directory.Exists(basePath))
                {
                    //TODO: Handle case
                    MessageBox.Show("Make sure the folder 'Avalanche Studios' exists in your documents.", "Could not find save folder.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                }

                if (Directory.Exists(Path.Combine(basePath, "Epic Games Store")))
                    basePath = Path.Combine(basePath, "Epic Games Store");

                Properties.Settings.Default.saveBasePath = basePath;
            }
        }
        private static void InitStoreDir()
        {
            Properties.Settings.Default.storePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "COTWSaveManager");
            
            Directory.CreateDirectory(Properties.Settings.Default.storePath);
        }



        public static string[] GetSaveList()
        {
            List<string> ret = new List<string>
            {
                "[ACTIVE] " + Properties.Settings.Default.activeSave
            };

            foreach (string path in Directory.GetFiles(Properties.Settings.Default.storePath, "*.zip"))
                ret.Add(Path.GetFileNameWithoutExtension(path));

            return ret.ToArray();
        }
        public static void StoreActiveSave()
        {
            string dest = Path.Combine(Properties.Settings.Default.storePath, Properties.Settings.Default.activeSave + ".zip");

            ZipFile.CreateFromDirectory(Properties.Settings.Default.saveBasePath, dest, CompressionLevel.Fastest, false, Encoding.Default);

            Directory.Delete(Properties.Settings.Default.saveBasePath, true);
            Directory.CreateDirectory(Properties.Settings.Default.saveBasePath);
        }
        public static void ActivateStoredSave(string saveName)
        {
            string src = Path.Combine(Properties.Settings.Default.storePath, saveName + ".zip");

            ZipFile.ExtractToDirectory(src, Properties.Settings.Default.saveBasePath, Encoding.Default);

            File.Delete(src);

            Properties.Settings.Default.activeSave = saveName;
            Properties.Settings.Default.Save();
        }
        public static void DeleteStoredSave(string saveName)
        {
            string src = Path.Combine(Properties.Settings.Default.storePath, saveName + ".zip");

            File.Delete(src);
        }
    }
}

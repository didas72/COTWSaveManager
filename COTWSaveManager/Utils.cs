using System;
using System.IO;

namespace COTWSaveManager
{
    internal static class Utils
    {
        public static bool HasDirectoryAccess(string dir)
        {
            try
            {
                File.Create(Path.Combine(dir, Path.GetRandomFileName()), 1, FileOptions.DeleteOnClose).Dispose();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static void MoveDirectoryRecursive(string src, string dest)
        {
            Directory.CreateDirectory(dest);

            foreach (string dir in Directory.GetDirectories(src))
            {
                string dirName = Path.GetFileName(dir);
                Directory.CreateDirectory(Path.Combine(dest, dirName));
                MoveDirectoryRecursive(dir, Path.Combine(dest, dirName));
            }

            foreach (string file in Directory.GetFiles(src, "*", SearchOption.TopDirectoryOnly))
                File.Move(file, Path.Combine(dest, Path.GetFileName(file)));

            Directory.Delete(src);
        }
    }
}

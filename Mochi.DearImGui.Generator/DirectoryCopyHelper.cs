using System.IO;

namespace Mochi.DearImGui.Generator;

public static class DirectoryCopyHelper
{
    public static void CopyDirectory(string sourceDir, string destDir, bool copySubDirs)
    {
        DirectoryInfo dir = new(sourceDir);
        DirectoryInfo[] dirs = dir.GetDirectories();

        if (!Directory.Exists(destDir))
        {
            Directory.CreateDirectory(destDir);
        }

        FileInfo[] files = dir.GetFiles();
        foreach (FileInfo file in files)
        {
            string tempPath = Path.Combine(destDir, file.Name);
            file.CopyTo(tempPath, true);
        }

        if (copySubDirs)
        {
            foreach (DirectoryInfo subDir in dirs)
            {
                string tempPath = Path.Combine(destDir, subDir.Name);
                CopyDirectory(subDir.FullName, tempPath, copySubDirs);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public static class FileManager
    {
        public static void GetFoldersAndFiles(string dirpath,string filename)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(dirpath);
            DirectoryInfo subDir = dirinfo.CreateSubdirectory("SAVInspect");
            string filepath = Path.Combine(subDir.FullName, "dirinfo.txt");
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine("список файлов: ");
                foreach (var file in dirinfo.GetFiles())
                {
                    writer.WriteLine(file.Name);
                }
                writer.WriteLine("список папок: ");
                foreach (var folder in dirinfo.GetDirectories())
                {
                    writer.WriteLine(folder.Name);
                }
            }
            string copyfilepath = Path.Combine(subDir.FullName, "copydirinfo.txt");
            File.Copy(filepath, copyfilepath, true);
            File.Move(copyfilepath, Path.Combine(subDir.FullName, filename));
            File.Delete(filepath);
        }
        public static void TaskB(string destination,string source,string extension)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(destination);
            DirectoryInfo subdir = dirinfo.CreateSubdirectory("savFiles");

            foreach (string filepath in Directory.GetFiles(source, extension))
            {
                string filename = Path.GetFileName(filepath);
                string copyTo = Path.Combine(subdir.FullName, filename);
                File.Copy(filepath, copyTo, true);
            }
            
        }
        public static void TaskC(string destination, string source, string toExtract)
        {
            ZipFile.CreateFromDirectory(source, destination);
            ZipFile.ExtractToDirectory(destination, toExtract);
        }

    }
}

namespace lab12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inspectpath = "C:\\Users\\леха\\Desktop\\3sem\\лабы\\oop\\lab12\\SAVInspect";
            DiskInfo.GetDiskInfo();
            SAVFileInfo.GetFileInfo("C:\\Users\\леха\\Desktop\\3sem\\лабы\\oop\\lab12\\lab12\\logfile.json");
            DirInfo.GetDirectoryInfo("C:\\Users\\леха\\Desktop\\3sem\\лабы\\oop\\lab12");
            FileManager.GetFoldersAndFiles("C:\\Users\\леха\\Desktop\\3sem\\лабы\\oop\\lab12","бибос.txt");

            FileManager.TaskB(inspectpath, "C:\\Users\\леха\\Desktop\\3sem\\лабы\\oop\\lab12\\source1","*.txt");
        }
    }
    ///сделать лог + обработка ошибок
}

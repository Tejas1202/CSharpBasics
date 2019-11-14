using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWithMoshConsoleApp
{
    class IOUtility
    {
        public static void FileBasics()
        {
            #region File (Provides static methods. Suitable when called less no. of times as OS does a security check everytime which hampers performance
            var path = @"E:\Elon Musk\HellBent.jpg";
            File.Copy(@"C:\Users\acer\Desktop\wallpapers\ElonOptimism.jpg", @"E:\Elon Musk\HellBent.jpg",true);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            var content = File.ReadAllText(path); //returns string
            #endregion

            #region FileInfo (Non static/Instance methods. Path given during object initialization itself hence don't have to explicitly pass it as params when calling methods
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"E:\Elon Musk\HellBent.jpg",true);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //TODO
            }
            fileInfo.OpenRead(); //returns FileStream
            #endregion

        }

        public static void DirectoryBasics()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"E:\Computer Science\C#\ProgrammingWithMoshConsoleApp", "*.sln", SearchOption.TopDirectoryOnly);

            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"E:\Computer Science", "*.*", SearchOption.TopDirectoryOnly);

            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}

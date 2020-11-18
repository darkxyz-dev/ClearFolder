using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples";
            DeleteAllfiles();
            DeleteAllfolders(rootpath);
        }
        //a function to delete all the files
        public static void DeleteAllfiles()
        {
            string rootpath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootpath);

            foreach (FileInfo file in directory.GetFiles()) 
            {
                file.Delete();
            }


        }
        //a function to delete all the folders
        public static void DeleteAllfolders(string folderName)
        {
            string rootpath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootpath);
            foreach(DirectoryInfo dirInfo in directory.GetDirectories())
            {
                DeleteAllfolders(dirInfo.FullName);
                dirInfo.Delete();
            }
        }
    }
}

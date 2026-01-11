using System;
using System.IO;
namespace FileIODemo;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
        if (Directory.Exists(directoryName))
        {
            Console.WriteLine("Folder already exists.");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            Console.WriteLine("Folder created.");
        }
    }

    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo = new DriveInfo(driveName);
        Console.WriteLine($"Drive Name: {dInfo.Name}");
        Console.WriteLine($"Drive Name: {dInfo.DriveType}");
    }


    public void PathDemoFunc()
    {
        //string s = @"C:\Users\vivek\Desktop\testingPut.txt”;

        // MessageBox.Show(Path.GetFileName(s));
        // MessageBox.Show(Path.GetTempPath(s));
    }
}

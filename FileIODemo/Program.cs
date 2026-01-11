// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace FileIODemo;

public class Program
{
    public static void Main()
    {
        DirectoryDemo dObj = new DirectoryDemo();
        dObj.DirectoryDemoFunc("Vivek");

        dObj.DriveInfoFunc("D:\\");

        FileStreamDemo fsDemoObj = new FileStreamDemo();
        //fsDemoObj.CreateFile(@" C:\Users\vivek\dot-net\newfile.txt");

        fsDemoObj.ReadFile(@"FilePath");
    }
}

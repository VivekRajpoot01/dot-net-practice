using System;
using System.IO;

namespace FileIODemo;

public class FileStreamDemo
{
    FileStream fs = null;

    public void CreateFile(string fileName)
    {
        StreamWriter sw = null;
        try
        {
            fs = new FileStream(fileName,FileMode.Create,FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine("This is just a sample file for FILE IO DEMo ");
        }
        catch(FileNotFoundException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch(FileLoadException e)
        {
            Console.WriteLine(e.Message);
        }
        sw.Close();
        fs.Close();
    }

    public void ReadFile(string fileName)
    {
        fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);

        Console.WriteLine(sr.ReadToEnd());

        sr.Close();
        fs.Close();
    }
}

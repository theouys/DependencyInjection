using System;
using System.IO;
public class FileLogger : ILogger 
{


    
    public void Log (string in_msg)
    {
        // Creating a file
        string myfile = @"file.txt";
 
        // Appending the given texts
        using(StreamWriter sw = File.AppendText(myfile))
        {
            sw.WriteLine(in_msg);
            sw.Close();
        }
        

    }
    
}
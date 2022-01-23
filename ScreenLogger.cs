public class ScreenLogger : ILogger 
{


    public void Log (string in_msg)
    {
        Console.WriteLine(in_msg);
    }
   
}
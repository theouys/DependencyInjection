public class Runner
{
    
    private ILogger _ILogger;

    public Runner(ILogger ilogger)
    {
        _ILogger = ilogger;
    }

    public void Runme() 
    {
        _ILogger.Log("test");
    }
  
}
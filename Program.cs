// See https://aka.ms/new-console-template for more information

//ScreenLogger s = new ScreenLogger();
FileLogger s = new FileLogger();
//Runner class just to run the program, you can also run it from Program.cs
//But then you should include the private variable and constructor.
Runner r = new Runner(s);
r.Runme();
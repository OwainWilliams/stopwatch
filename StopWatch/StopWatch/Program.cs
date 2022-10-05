using StopWatchProgram;

var stopwatch = new Stopwatch();
Console.WriteLine("Type 'start' to start the stopwatch. Type 'quit' to close program");
var input = Console.ReadLine();
var watchStarted = false;


while(input != null && input != "quit")
{
    if (input != null && input.ToLower() == "start")
    {
        if (!watchStarted)
        {
            Console.WriteLine("Stopwatch started. Type 'stop' to stop the stopwatch");
            watchStarted = true;
            Console.WriteLine("Started at: " + stopwatch.Start());
            input = Console.ReadLine();

        }
        else
        {
            Console.WriteLine("Stopwatch has already been started");
            input = Console.ReadLine(); 
        }

    }
    if( input != null && input.ToLower() == "stop")
    {
        
        Console.WriteLine();
        Console.WriteLine("Stopwatch stopped");
        watchStarted = false;
        Console.WriteLine("Stopped at: " + stopwatch.Stop());
        Console.WriteLine(stopwatch.ElapsedTime() + " has passed between starting and stopping the stopwatch");
        input = Console.ReadLine();
    }




}

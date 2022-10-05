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
            watchStarted = true;
            stopwatch.Start();
            input = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Stopwatch has already been started");
            input = Console.ReadLine(); 
        }

    } else if( input != null && input.ToLower() == "stop")
    {
        watchStarted = false;
        stopwatch.Stop();  
        input = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Command not recognised");
        input = Console.ReadLine();
    }




}

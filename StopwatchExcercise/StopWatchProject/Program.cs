using StopWatchProgram;

class Program
{
    static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        Console.WriteLine("Type 'start' to start the stopwatch. Type 'quit' to close program");
        var input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input) && input != "quit")
        {

            switch (input)
            {
                case "quit":
                    break;
                case "start":
                    Console.WriteLine(stopwatch.Start());
                    break;
                case "stop":
                    Console.WriteLine(stopwatch.Stop());
                    Console.WriteLine(stopwatch.ElapsedTime());
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }

            input = Console.ReadLine();

        }

    }
}



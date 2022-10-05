namespace StopWatchProgram
{

    public class Stopwatch
    {
        private TimeOnly startedTime = new TimeOnly();
        private TimeOnly stoppedTime = new TimeOnly();

        public void Start()
        {
            Console.WriteLine("Stopwatch started. Type 'stop' to stop the stopwatch");

            startedTime = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(startedTime);
            

        }

        public void Stop()
        {
            Console.WriteLine();
            Console.WriteLine("Stopwatch stopped");
            stoppedTime = TimeOnly.FromDateTime(DateTime.Now);

            Console.WriteLine("Stopped at: " + stoppedTime);

            Console.WriteLine(ElapsedTime() + " has passed between starting and stopping the stopwatch"); ;
        }

        public TimeSpan ElapsedTime()
        {
            var elapsedTime = stoppedTime - startedTime;
            return elapsedTime;
        }
    }
}

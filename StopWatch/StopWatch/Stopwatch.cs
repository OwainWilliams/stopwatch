namespace StopWatchProgram
{
    public class Stopwatch
    {
        private TimeOnly startedTime = new TimeOnly();
        private TimeOnly stoppedTime = new TimeOnly();

        public TimeOnly Start()
        {
            startedTime = TimeOnly.FromDateTime(DateTime.Now);
            return startedTime;

        }

        public TimeOnly Stop()
        {
            stoppedTime = TimeOnly.FromDateTime(DateTime.Now);
            return stoppedTime;
            
        }

        public TimeSpan ElapsedTime()
        {
            var elapsedTime = stoppedTime - startedTime;
            return elapsedTime;
        }
    }
}

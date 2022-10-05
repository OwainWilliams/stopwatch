namespace StopWatchProgram
{

    public class Stopwatch
    {
        private TimeOnly startedTime = new TimeOnly();
        private TimeOnly stoppedTime = new TimeOnly();
        private bool timerStarted = false;

        public string Start()
        {
            if (!timerStarted)
            {
                startedTime = TimeOnly.FromDateTime(DateTime.Now);
                timerStarted = true;

                return "Stopwatch started at : " + startedTime.ToString();
            }
            else
            {
                return "Stopwatch has already started";
            }
        }

        public string Stop()
        {
            stoppedTime = TimeOnly.FromDateTime(DateTime.Now);
            timerStarted = false;
            return "Stopwatch stopped";
        }

        public string ElapsedTime()
        {
            TimeSpan elapsedTime = stoppedTime - startedTime;
            return "Stopwatch ran for : " + elapsedTime;
        }
    }
}

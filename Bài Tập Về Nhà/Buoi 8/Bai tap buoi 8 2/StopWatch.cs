public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    // Getter
    public DateTime StartTime => startTime;
    public DateTime EndTime => endTime;

    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public double GetElapsedTime()
    {
        TimeSpan elapsedTime = endTime - startTime;
        return elapsedTime.TotalMilliseconds;
    }
}

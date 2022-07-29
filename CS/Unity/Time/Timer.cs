using UnityEngine;

public class Timer
{
    public double startTime = 0;
    public double stopTime = 0;

    public double totalTimeElapsed = 0;

    public bool isRunning = false;


    public Timer(bool startOnInit = false)
	{
        if(startOnInit)
		{
            StartTimer();
        }
	}

    public void StartTimer()
    {
        startTime = Time.Time;

        isRunning = true;
    }

    public void StopTimer()
    {
        stopTime = Time.Time;

        isRunning = false;
    }

    public void PauseTimer()
    {
        totalTimeElapsed += Time.Time - startTime;
        startTime = Time.Time;
        stopTime = Time.Time;

        isRunning = false;
    }

    public void ResumeTimer()
    {
        startTime = Time.Time;

        isRunning = true;
    }

    public virtual double GetTime()
    {
        if (isRunning)
        {
            return (Time.Time - startTime) + totalTimeElapsed;
        }
        else
        {
            return (stopTime - startTime) + totalTimeElapsed;
        }
    }
}
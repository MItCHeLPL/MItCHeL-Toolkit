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
        startTime = Time.time;

        isRunning = true;
    }

    public void StopTimer()
    {
        stopTime = Time.time;

        isRunning = false;
    }

    public void PauseTimer()
    {
        totalTimeElapsed += Time.time - startTime;
        startTime = Time.time;
        stopTime = Time.time;

        isRunning = false;
    }

    public void ResumeTimer()
    {
        startTime = Time.time;

        isRunning = true;
    }

    public virtual double GetTime()
    {
        if (isRunning)
        {
            return (Time.time - startTime) + totalTimeElapsed;
        }
        else
        {
            return (stopTime - startTime) + totalTimeElapsed;
        }
    }
}
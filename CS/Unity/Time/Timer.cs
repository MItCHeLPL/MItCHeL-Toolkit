using UnityEngine;

public class Timer
{
    public double StartTime = 0;
    public double StopTime = 0;

    public double TotalTimeElapsed = 0;

    public bool IsRunning = false;


    public Timer(bool startOnInit = false)
	{
        if(startOnInit)
		{
            StartTimer();
        }
	}

    public void StartTimer()
    {
        StartTime = Time.time;

        IsRunning = true;
    }

    public void StopTimer()
    {
        StopTime = Time.time;

        IsRunning = false;
    }

    public void PauseTimer()
    {
        TotalTimeElapsed += Time.time - StartTime;
        StartTime = Time.time;
        StopTime = Time.time;

        IsRunning = false;
    }

    public void ResumeTimer()
    {
        StartTime = Time.time;

        IsRunning = true;
    }

    public virtual double GetTime()
    {
        if (IsRunning)
        {
            return (Time.time - StartTime) + TotalTimeElapsed;
        }
        else
        {
            return (StopTime - StartTime) + TotalTimeElapsed;
        }
    }
}
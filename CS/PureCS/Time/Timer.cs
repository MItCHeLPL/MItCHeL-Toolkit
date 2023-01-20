using System;
using System.Collections.Generic;
using System.Text;

public class Timer
{
    public long StartTime = 0;
    public long StopTime = 0;
    public long TotalTimeElapsed = 0;
    public bool IsRunning = false;

    public Timer(bool startOnInit = false)
    {
        if (startOnInit)
        {
            StartTimer();
        }
    }

    public void StartTimer()
    {
        StartTime = DateTime.Now.Ticks;
        IsRunning = true;
    }

    public void StopTimer()
    {
        StopTime = DateTime.Now.Ticks;
        IsRunning = false;
    }

    public void PauseTimer()
    {
        TotalTimeElapsed += DateTime.Now.Ticks - StartTime;
        StartTime = DateTime.Now.Ticks;
        StopTime = DateTime.Now.Ticks;
        IsRunning = false;
    }

    public void ResumeTimer()
    {
        StartTime = DateTime.Now.Ticks;
        IsRunning = true;
    }

    public virtual long GetTime()
    {
        if (IsRunning)
        {
            return (DateTime.Now.Ticks - StartTime) + TotalTimeElapsed;
        }
        else
        {
            return (StopTime - StartTime) + TotalTimeElapsed;
        }
    }
}
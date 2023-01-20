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
        StartTime = PhotonNetwork.time;

        IsRunning = true;
    }

    public void StopTimer()
    {
        StopTime = PhotonNetwork.time;

        IsRunning = false;
    }

    public void PauseTimer()
    {
        TotalTimeElapsed += PhotonNetwork.time - StartTime;
        StartTime = PhotonNetwork.time;
        StopTime = PhotonNetwork.time;

        IsRunning = false;
    }

    public void ResumeTimer()
    {
        StartTime = PhotonNetwork.time;

        IsRunning = true;
    }

    public virtual double GetTime()
    {
        if (IsRunning)
        {
            return (PhotonNetwork.time - StartTime) + TotalTimeElapsed;
        }
        else
        {
            return (StopTime - StartTime) + TotalTimeElapsed;
        }
    }
}
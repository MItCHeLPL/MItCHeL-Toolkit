using UnityEngine;

public class CountdownTimer : Timer
{
	public double countdown = 5;

	public CountdownTimer(){ }
	public CountdownTimer(double countdown, bool startOnInit = false) 
	{
		this.countdown = countdown;

		if(startOnInit)
		{
			StartTimer();
		}
	}

	public void StartTimer(double countdown)
	{
		this.countdown = countdown;

		StartTimer();
	}

	public override double GetTime()
	{
		if(countdown - base.GetTime() <= 0)
		{
			StopTimer();
		}

		return countdown - base.GetTime();
	}
}

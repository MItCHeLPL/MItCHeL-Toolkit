public class CountdownTimer : Timer
{
	public double Countdown = 5;

	public CountdownTimer(){ }
	public CountdownTimer(double countdown, bool startOnInit = false) 
	{
		this.Countdown = countdown;

		if(startOnInit)
		{
			StartTimer();
		}
	}

	public void StartTimer(double countdown)
	{
		this.Countdown = countdown;

		StartTimer();
	}

	public override double GetTime()
	{
		if(Countdown - base.GetTime() <= 0)
		{
			StopTimer();
		}

		return Countdown - base.GetTime();
	}
}

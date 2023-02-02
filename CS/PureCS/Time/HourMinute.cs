using System;

public class HourMinute
{
    private int Time = 0;

    public int Hours24 => (int)Math.Floor((double)(Time / 60));
    public int Hours12 => Hours24 % 12 == 0 ? 12 : Hours24 % 12;
    public int Minutes => Time % 60;
    public string AMPM => Hours24 >= 12 ? "PM" : "AM";


    public HourMinute(int time)
    {
        SetTime(time);
    }

    public HourMinute(int hours, int minutes)
    {
        SetTime(hours, minutes);
    }


    public void SetTime(int time)
    {
        time %= 24 * 60;

        Time = time;
    }

    public void SetTime(int hours, int minutes)
    {
        //Raise hours if minutes goes over 59
        if (minutes > 59)
        {
            hours += (int)Math.Floor((double)(minutes / 60));
        }

        minutes %= 60;

        hours %= 24;

        Time = (hours * 60) + minutes;
    }


    public override string ToString()
    {
        return ToString("24");
    }

    public string ToString(string format)
    {
        string minutes = Minutes < 10 ? $"0{Minutes}" : $"{Minutes}";

        if (format == "12")
        {
            return $"{Hours12}:{minutes} {AMPM}";
        }
        else
        {
            return $"{Hours24}:{minutes}";
        }
    }
}
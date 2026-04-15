using System;

public class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {return 0;}

    public virtual double GetSpeed()
    {return 0;}

    public virtual double GetPace()
    {return 0;}

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace {GetPace():0.0}";
    }

    protected int GetLength()
    {
        return _lengthMinutes;
    }
}
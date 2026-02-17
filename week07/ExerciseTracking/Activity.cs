using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minuted)
    {
        _date = date;
        _minutes = minuted;
    }

    public int GetMinutes() => _minutes;
    public string GetDate() => _date;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {this.GetType().Name} ({GetMinutes()} min): " +
                $"Distance: {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
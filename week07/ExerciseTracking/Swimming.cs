using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthInMinutes, int laps) 
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 1 lap = 50 meters, 1 km = 1000 meters
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / GetDistance();
    }
}

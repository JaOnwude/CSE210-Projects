using System;

public class Running : Activity
{
    private double _distanceInKm;

    public Running(string date, int lengthInMinutes, double distanceInKm) 
        : base(date, lengthInMinutes)
    {
        _distanceInKm = distanceInKm;
    }

    public override double GetDistance()
    {
        return _distanceInKm;
    }

    public override double GetSpeed()
    {
        return (_distanceInKm / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / _distanceInKm;
    }
}

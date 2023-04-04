using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    // Base Activity class with shared attributes and virtual methods
    public class Activity
    {
        public DateTime date;
        public int minutes; // in minutes

        public Activity(DateTime date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        // virtual methods to be overridden in the derived classes
        public virtual double GetDistance()
        {
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            return 0.0;
        }

        public virtual double GetPace()
        {
            return 0.0;
        }

        // GetSummary method to produce a string with all the summary information
        public virtual string GetSummary()
        {
            return $"{date.ToString("dd MMM yyyy")} {this.GetType().Name} ({minutes} min)";
        }
    }

    // Define the Running class
class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / minutes) * 60;
    }

    public override double GetPace()
    {
        return minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Running ({minutes} min)- Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}

// Define the Swimming class
class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / minutes) * 60;
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Swimming ({minutes} min)- Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}

// Define the Cycling class
class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * minutes;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetDistance() / minutes;
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Cycling ({minutes} min)- Distance {GetDistance():F1} km, Speed {_speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
        }

    class Program
{
    static void Main(string[] args)
    {
        // create instances of each activity type
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 20);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        // add each activity to a list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // iterate through the list and call GetSummary on each item
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.ReadLine();
    }
}
    
    }
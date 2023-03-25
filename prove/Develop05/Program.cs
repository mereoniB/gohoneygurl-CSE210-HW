using System;
using System.Collections.Generic;

// Base class for all goals
class Goal
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Frequency { get; set; }
    public string AchievementText { get; set; }
    public int PointValue { get; set; }

    // Virtual method for completing a goal
    public virtual void Complete()
    {
        Console.WriteLine("Goal completed!");
    }

    // Virtual method for checking if goals are available
    public virtual bool GoalsAvailable()
    {
        return true;
    }
}

// Derived class for Eternal goals
class EternalGoals : Goal
{
    // Override Complete method to reflect completion of Eternal Goals
    public override void Complete()
    {
        Console.WriteLine("Eternal Goal completed!");
    }

    // Override GoalsAvailable method to reflect availability of Eternal Goals
    public override bool GoalsAvailable()
    {
        return true;
    }
}

// Derived class for Checklist goals
class ChecklistGoal : Goal
{
    // Override Complete method to reflect completion of Checklist Goals
    public override void Complete()
    {
        Console.WriteLine("Checklist Goal completed!");
    }

    // Override GoalsAvailable method to reflect availability of Checklist Goals
    public override bool GoalsAvailable()
    {
        return true;
    }
}

// Class for the User Interface
class UI
{
    // Method to format user score
    public string FormatUserScore(int score)
    {
        return "User score: " + score.ToString();
    }

    // Method to format the goal list
    public string FormatGoalList(List<Goal> goals)
    {
        string output = "";

        foreach (var goal in goals)
        {
            output += goal.ID.ToString() + ": " + goal.Name + "\n";
        }

        return output;
    }

    // Method to create a new goal
    public Goal CreateGoal(int id, string name, string description, int frequency, string achievementText, int pointValue, string goalType)
    {
        Goal goal;

        if (goalType == "Eternal")
        {
            goal = new EternalGoals();
        }
        else if (goalType == "Checklist")
        {
            goal = new ChecklistGoal();
        }
        else
        {
            goal = new Goal();
        }

        goal.ID = id;
        goal.Name = name;
        goal.Description = description;
        goal.Frequency = frequency;
        goal.AchievementText = achievementText;
        goal.PointValue = pointValue;

        return goal;
    }

    // Method to display record result dialog
    public void RecordResultDialog()
    {
        Console.WriteLine("Record result dialog displayed.");
    }
}

// Class for the Scoreboard
class Scoreboard
{
    List<Goal> completedGoals = new List<Goal>();

    // Method to get the user score
    public int GetScore()
    {
        int score = 0;

        foreach (var goal in completedGoals)
        {
            score += goal.PointValue;
        }

        return score;
    }
}

// Class for file input/output operations
class FileIO
{
    // Method to save goals to file
    public void SaveFile(string path, List<Goal> goals)
    {
        // Implementation code here
    }

    // Method to load goals from file
    public List<Goal> LoadFile(string path)
    {
        // Implementation code here
        return new List<Goal>();
    }
}

// Class for


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
    }
}
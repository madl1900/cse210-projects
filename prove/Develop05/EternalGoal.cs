public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        _timesCompleted += 1;
        _earnedPoints += _points;

        Console.WriteLine();
        Console.WriteLine($"You earned {_points} points!");
        Thread.Sleep(750);
    }

    public override string DisplayGoal()
    {
        return $"[ ] {_name}: {_description} -- Completed {_timesCompleted} times";
    }

    public override string SaveGoal()
    {
        // TODO: check if this needs to be changed
        return $"EternalGoal,{_name},{_description},{_points},{_isComplete},{_timesCompleted},{_earnedPoints}";
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
}
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
     GetEarnedPoints();   
    }

    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("You already completed this goal.");
        }

        else
        {
            _isComplete = true;
            _earnedPoints += _points;

            Console.WriteLine();
            Console.WriteLine($"You earned {_points} points!");
        }
        Thread.Sleep(750);
    }

    public override string DisplayGoal()
    {
        string checkbox = "[ ]";

        if (_isComplete)
        {
           checkbox = "[X]";
        }

        return $"{checkbox} {_name}: {_description}";
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete},{_earnedPoints}";
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

}
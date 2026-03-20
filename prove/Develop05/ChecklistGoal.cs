public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesToComplete;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timesToComplete) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _timesToComplete = timesToComplete;
    }

    public override void RecordEvent()
    {
        _timesCompleted += 1;

        if (_isComplete)
        {
            Console.WriteLine("You already completed this goal.");
        }
        else
        {
            if (_timesCompleted < _timesToComplete)
            {
                _earnedPoints += _points;
            
                Console.WriteLine();
                Console.WriteLine($"You earned {_points} points!");
            }
            else
            {
                _isComplete = true;
                _earnedPoints = _earnedPoints + _points + _bonusPoints;
            
                Console.WriteLine();
                Console.WriteLine($"You earned {_points+_bonusPoints} points!");    
            }
        }
        Thread.Sleep(750);
    }

    public override string DisplayGoal()
    {
        string checkbox = "[ ]";
        if (_isComplete)
        {
            checkbox = "[X] ";
        }
        return $"{checkbox} {_name}: {_description} -- Completed {_timesCompleted}/{_timesToComplete} times";
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonusPoints},{_isComplete},{_timesToComplete},{_timesCompleted},{_earnedPoints}";
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;
    protected int _earnedPoints;
    

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
        _earnedPoints = 0;
    }

    public abstract void RecordEvent();

    public abstract string DisplayGoal();

    public abstract string SaveGoal();

    public int GetPoints()
    {
        return _points;
    }

    public int GetEarnedPoints()
    {
        return _earnedPoints;
    }

    public void SetEarnedPoints(int points)
    {
        _earnedPoints = points;
    }
}
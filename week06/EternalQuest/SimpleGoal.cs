public class SimpleGoal : Goal
{
    private bool _isComplete; // Simple goals can be completed. 

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        //Constructor is identical to the base Goal class
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        //The simple goal is now completed. We will mark it as done, and return how any points it is worth.
        _isComplete = true;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Goal: {_name}\nDescription: {_description}\nType: Simple\nCompleted:{_isComplete}";
    }

    
}
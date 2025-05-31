public class SimpleGoal : Goal
{
    private bool _isComplete; // Simple goals can be completed. 
        
    public bool IsComplete // For Serialization
    {
        get => _isComplete;
        set => _isComplete = value;
    }

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        _isComplete = false;
    }

    public override bool IsCompleted()
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
        string comp = " ";
        if (IsCompleted())
        {
            comp = "X";
        }
        return $"Goal: {_name}\nDescription: {_description}\nType: Simple\nCompleted:[{comp}]";
    }

    
}
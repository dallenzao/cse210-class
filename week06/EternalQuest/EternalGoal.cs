public class EternalGoal : Goal
{
    private int _count; // How many times the Eternal Goal was completed
    public int Count // For Serialization
    {
        get => _count;
        set => _count = value;
    }

    public EternalGoal(string name, string desc, int points) : base(name, desc, points)
    {
        //Constructor is identical to the base Goal class
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override int RecordEvent()
    {
        //This is an Eternal Goal. It cant be fully completed. Add one to the counter, then return the points
        _count++;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Goal: {_name}\nDescription: {_description}\nType: Eternal\nCompleted:{_count} Times";
    }

    
}
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public string Name //For Serialization
    {
        get => _name;
        set => _name = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public int Points
    {
        get => _points;
        set => _points = value;
    }

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points; //How Many points the goal is worth
    }

    public string GetName()
    {
        return _name;
    }

    public abstract bool IsCompleted();

    public abstract int RecordEvent();

    public abstract string GetStringRepresentation();

    public virtual string GetStringDetails() {
        return $"Goal: {_name}\nDescription: {_description}";    
    }

    
}
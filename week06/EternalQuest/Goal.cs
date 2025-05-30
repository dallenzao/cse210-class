public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

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

    public abstract bool IsComplete();

    public abstract int RecordEvent();

    public abstract string GetStringRepresentation();

    
}
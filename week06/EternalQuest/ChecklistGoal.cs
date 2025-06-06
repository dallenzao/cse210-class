public class ChecklistGoal : Goal
{
    private int _amountCompleted; // How many times the Checklist Goal was completed
    private int _target; // How many times do you want to complete this goal?
    private int _bonus; //If you hit the target, bonus moment.
    public int AmountCompleted //For Serialization
    {
        get => _amountCompleted;
        set => _amountCompleted = value;
    }

    public int Target
    {
        get => _target;
        set => _target = value;
    }

    public int Bonus
    {
        get => _bonus;
        set => _bonus = value;
    }

    public ChecklistGoal(string name, string desc, int points, int target, int bonus) : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override bool IsCompleted()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        return true;
    }

    public override int RecordEvent()
    {
        //This is an Checklist Goal. It is. Add one to the counter, then return the points
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus; //If you hit the target, return the points + the bonus instead
        }
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Goal: {_name}\nDescription: {_description}\nType: Checklist\nCompleted:{_amountCompleted}/{_target} Times";
    }    
}
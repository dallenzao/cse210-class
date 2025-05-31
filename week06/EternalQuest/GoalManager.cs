public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public List<Goal> Goals //Serialzation variables
    {
        get => _goals;
        set => _goals = value;
    }

    public int Score
    {
        get => _score;
        set => _score = value;
    }

    public GoalManager()
    {

    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Lets create a goal!\n What type of goal would you like to add? (Enter Number)");
        Console.WriteLine("1) Simple Goal - Do this goal once");
        Console.WriteLine("2) Eternal Goal - Continue to work on this goal");
        Console.WriteLine("3) Checklist Goal - Do this goal a certain number of times");

        bool validInput = false; // This is for error checking, if the user enters an incorrect number. 
        string a = "";
        
        while (!validInput)
        {
            Console.WriteLine("Enter a number (1 = Simple goal, 2 = Eternal goal, 3 = Checklist goal):");
            a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.WriteLine("Simple goal. Great!");
                    validInput = true;
                    break;
                case "2":
                    Console.WriteLine("Eternal goal. Great!");
                    validInput = true;
                    break;
                case "3":
                    Console.WriteLine("Checklist goal. Great!");
                    validInput = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    break;
            }
        }

        Console.WriteLine("What do you want to call this goal?");
        string name = Console.ReadLine();

        Console.WriteLine("Give a description of this goal.");
        string desc = Console.ReadLine();

        int points = StringtoIntErrorCheck("How many points should this goal be worth every time you complete it?");

        switch (a)
        {
            case "1": //Simple Goal
                SimpleGoal sg = new SimpleGoal(name, desc, points);
                _goals.Add(sg);
                break;
            case "2":
                EternalGoal eg = new EternalGoal(name, desc, points);
                _goals.Add(eg);
                break;
            case "3":
                int target = StringtoIntErrorCheck("What is your target for how many times to complete the goal?");
                int bonus = StringtoIntErrorCheck("When you reach your target, how many bonus points should you get?");
                ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);
                _goals.Add(cg);
                break;
        }
    }

    public int StringtoIntErrorCheck(string text)
    //The Create goal needs to verify if a strring can be converted to a int many times. This function cleans up the code. 
    {
        bool validInput = false;
        int num = 0;
        while (!validInput)
        {
            Console.WriteLine(text);
            string numString = Console.ReadLine();
            try
            {
                int.TryParse(numString, out num);
                if (num <= 0)
                {
                    Console.WriteLine("Incorrect Response. You need to enter a whole number above 0");
                }
                else
                {
                    validInput = true;
                }
            }
            catch
            {
                Console.WriteLine("Incorrect Response. You need to enter a whole number above 0");
            }
        }
        return num;
    }

    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine("-------");
            Console.WriteLine(g.GetStringRepresentation());
        }
        Console.WriteLine("-------");
    }

    public void RecordEvent()
    {
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}) {g.GetStringDetails()}");
            i++;
        }
        Console.WriteLine("-------");
        bool validInput = false;
        while (!validInput)
        {
            int num = StringtoIntErrorCheck("Which goal would you like to record an event in? Enter number:");
            try
            {
                _score += _goals[num - 1].RecordEvent();
                if (_goals[num - 1].IsCompleted())
                {
                    Console.WriteLine("Your goal is completed!");
                }
                Console.WriteLine($"Event Recorded! You now have {_score} points.");
                validInput = true;
            }
            catch
            {
                Console.WriteLine($"You must enter a valid number!");
            }

        }


    }

    public void ShowPoints()
    {
        Console.WriteLine($"You currently have {_score} points!");
    }
}

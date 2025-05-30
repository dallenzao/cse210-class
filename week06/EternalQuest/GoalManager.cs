public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

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
        Console.WriteLine("Enter a number (1 = Simple goal, 2 = Eternal goal, 3 = Checklist goal):");
        string a = Console.ReadLine();
        
        while (!validInput)
        {
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
                break;
            case "2":
                EternalGoal eg = new EternalGoal(name, desc, points);
                break;
            case "3":
                int target = StringtoIntErrorCheck("What is your target for how many times to complete the goal?");
                int bonus = StringtoIntErrorCheck("When you reach your target, how many bonus points should you get?");
                ChecklistGoal cg = new ChecklistGoal(name, desc, target, bonus);
                break;
        }
    }

    public int StringtoIntErrorCheck(string text)
    //The Create goal needs to verify if a strring can be converted to a int many times. This function cleans up the code. 
    {
        bool validInput = false;
        while (!validInput)
        {
            Console.WriteLine(text);
            string numString = Console.ReadLine();
            try
            {
                int num = int.TryParse(numString);
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
}
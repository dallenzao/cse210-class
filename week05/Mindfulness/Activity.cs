//Dallen Harmon
//CSE 210

public class Activity //Base Activity Class, which the others inherit.
{
    private string _name;
    private string _description;
    protected int _duration; // This is needed in the other classes. Protected (not private) allows derived classes ONLY to access this variable. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage() //Displays a starting message, and gets a length of the activity from the user. 
    {
        Console.Clear();
        Console.WriteLine($"{_name}: {_description}"); // Prints what the activity is
        Console.Write("Enter desired activity duration (in Seconds): ");
        string duration = Console.ReadLine();
        try
        {
            _duration = int.Parse(duration); //Trys to make the users response into an int. If it fails, the below message will send
        }
        catch
        {
            //If the user fails to put in a correct number, itll default to 60 seconds long.
            Console.WriteLine("A whole number was not entered. Setting duration to default value of 60 seconds");
            _duration = 60;
        }
        Console.Write($"Get ready! Starting in ");
        ShowCountdown(5); //Shows a small counter before it starts the activity

    }

    public void DisplayEndingMessage()// Words t display at the end of the activity
    {
        Console.Write($"Great job! ");
        ShowSpinner(5); // Give the user a few second break

        Console.WriteLine($" ");
        Console.WriteLine($"You just completed {_duration} seconds of the {_name} activity!"); //Remind them what they did and how long they did it, then return to the main menu
        Console.Write($"Returning to main menu in ");
        ShowCountdown(5);
    }

    public void ShowSpinner(int second)
    {
        for (int i = 0; i < second; i++)//Makes a "Spinner" that spins every second. How many seconds entered, is how many times itll spin
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

        }
    }

    public void ShowCountdown(int second) //Show a numerical countdown to the user
    {
        for (int i = second; i > 0; i--)
        {
            string numStr = i.ToString();
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b ");
            Console.Write(new string('\b', numStr.Length)); // This will remove the entire number if its more than 1 digit long (100 itll delete 3 times for example)

        }
    }

}



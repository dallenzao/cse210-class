//Dallen Harmon
//CSE210
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        //Makes the lists with prompts and questions
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = 0;
        Console.Clear();
        GetRandomInList(_prompts); //Prints a random prompt
        Console.WriteLine("");
        Console.Write("Think about this prompt... ");
        ShowCountdown(20); // Waits 20 seconds
        Console.WriteLine("");

        while (seconds < _duration)
        {
            if (seconds % 10 == 0)
            {
                GetRandomInList(_questions); // Every 10 seconds, print a random question. 
            }
            ShowSpinner(1); //Show the spinner for 1 second
            seconds++; // Add a second to the counter
        }

        Console.Clear();
        DisplayEndingMessage();
    }

    public void GetRandomInList(List<string> strings) //Prints a random item from a list
    {
        Random num = new Random();
        int randomnum = num.Next(0, strings.Count); //Gets a random spot in the list based on its length
        Console.WriteLine(strings[randomnum]); //Prints whatever string is in that spot
    }
}
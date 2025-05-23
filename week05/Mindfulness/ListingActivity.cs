//Dallen Harmon
//CSE210
public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        //Makes the lists with prompts
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        GetRandomInList(_prompts); //Prints a random prompt
        Console.WriteLine($"Ponder this prompt. Start typing in responses in ");
        ShowCountdown(15);
        Console.WriteLine("");

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);

        while (currentTime < futureTime) //For the specified duration, wait for the user to enter stuff. When they press enter, itll add one to the counter.
        {
            Console.ReadLine();
            _count++;
            currentTime = DateTime.Now;
        }

        Console.Clear();
        Console.WriteLine($"You listed {_count} items!"); //Tells the user how many things they listed
        DisplayEndingMessage();
    }

    public void GetRandomInList(List<string> strings) //Prints a random item from a list
    {
        Random num = new Random();
        int randomnum = num.Next(0, strings.Count); //Gets a random spot in the list based on its length
        Console.WriteLine(strings[randomnum]); //Prints whatever string is in that spot
    }
}
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
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("");
        GetRandomInList(_prompts);
        Console.WriteLine($"Ponder this prompt. Start typing in responses in ");
        ShowCountdown(15);
        Console.WriteLine("");
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        while (currentTime < futureTime)
        {
            Console.ReadLine();
            _count++;
            currentTime = DateTime.Now;
        }
        Console.Clear();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
}
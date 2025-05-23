public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {
        //All variables are in the base class
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        int seconds = 0;
        while (seconds < _duration)
        {
            Console.Clear();
            Console.Write("Breathe in");
            for (int i = 0; i < 10; i++)
            {
                if (seconds >= _duration) { break; } //If the specified duration passes at any point, itll break the loops
                Console.Write(".");
                Thread.Sleep(1000);
                seconds++;
            }
            Console.WriteLine(" ");
            if (seconds >= _duration) { break; }
            Console.Write("Breathe out");

            for (int i = 0; i < 10; i++)
            {
                if (seconds >= _duration) { break; }
                Console.Write(".");
                Thread.Sleep(1000);
                seconds++;
            }
        }
        Console.Clear();
        DisplayEndingMessage();
    }

}
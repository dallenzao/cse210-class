//Dallen Harmon
//CSE210
public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {
        //All variables are in the base class
    }

    public void Run()
    {
        DisplayStartingMessage();

        int seconds = 0;
        while (seconds < _duration) //For the specified duration, do the activity
        {
            Console.Clear();
            Console.Write("Breathe in  ");
            for (int i = 0; i < 4; i++)
            {
                if (seconds >= _duration) { break; } //If the specified duration passes at any point, itll break the loop!
                Console.Write("."); // Every second add a dot.
                Thread.Sleep(1000);
                seconds++;
            }
            Console.WriteLine(" ");
            if (seconds >= _duration) { break; }
            Console.Write("Breathe out ");

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
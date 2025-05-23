//Dallen Harmon
//CSE210

/*Extra things added to base functionality:
In activity class, there is error checking to see if the user actually entered a number for the duration
If they dont enter a number, or its not valid, itll tell the user that they entered the wrong thing and use a default value.

Other than that I tried to follow the instructions for the base line.
*/

class Program
{
    static void Main(string[] args)
    {
        bool running = true;//Keep the menu going unless the user quits
        while (running)
        {
            Console.Clear(); //Clears and gives the user a list of things to do.
            Console.WriteLine("Welcome to the Mindfullness Program. Please choose from the following:");
            Console.WriteLine("1 - Breathing Activity");
            Console.WriteLine("2 - Reflecting Activity");
            Console.WriteLine("3 - Listing Activity");
            Console.WriteLine("4 - Quit the program");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity b = new BreathingActivity("Breathing", "This activity will help you relax. Clear your mind, focus on your breathing, and calm your body.");
                    b.Run();
                    break;
                case "2":
                    ReflectingActivity r = new ReflectingActivity("Reflecting", " This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                    r.Run();
                    break;
                case "3":
                    ListingActivity l = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                    l.Run();
                    break;
                case "4":
                    running = false;
                    break;
            }
        }
        Console.WriteLine("Thanks for being well with us."); //End of program.
    }
}
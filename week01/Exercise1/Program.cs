using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First Name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your Last Name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}");
    }
}
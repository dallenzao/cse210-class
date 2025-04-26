using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sqnum = SquareNumber(num);
        DisplayResult(name, sqnum);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.Write("What is your name?\n");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("What is your favorite number?\n");
        string strnumber = Console.ReadLine();
        int number = int.Parse(strnumber);
        return number;
    }
    static int SquareNumber(int num){
        return num*num;
    }
    static void DisplayResult(string name, int sqnum){
        Console.WriteLine($"{name}, The square of your number is {sqnum}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Grade Percentage? ");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr);
        string gradeLetter = "";
        bool pass = true;
        if (grade < 60){
            gradeLetter = "F";
            pass = false;
            }
        else if (grade < 70){
            if (grade < 63){
                gradeLetter = "D-";
                pass = false;
            }
            else if (grade >= 67){
                gradeLetter = "D+";
                pass = false;
            }
            else{
                gradeLetter = "D";
                pass = false;
            }
        }
        else if (grade < 80){
            if (grade < 73){
                gradeLetter = "C-";
            }
            else if (grade >= 77){
                gradeLetter = "C+";
            }
            else{
                gradeLetter = "C";
            }
        }
        else if (grade < 90){
            if (grade < 83){
                gradeLetter = "B-";
            }
            else if (grade >= 87){
                gradeLetter = "B+";
            }
            else{
                gradeLetter = "B";
            }
        }
        else if (grade < 100){
            if (grade < 93){
                gradeLetter = "A-";
            }
            else{
                gradeLetter = "A";
            }
        }
        else{
            Console.WriteLine("Invalid Number. Please enter a whole number between 0 and 100");
        }
        Console.WriteLine($"Grade = {gradeLetter}");
        if (pass) {
            Console.WriteLine($"Congrats on Passing!");
        }
        else{
            Console.WriteLine($"Sorry. Try to study harder next time.");
        }
    }
}
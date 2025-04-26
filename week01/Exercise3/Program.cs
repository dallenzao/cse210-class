using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {   
        bool active = false;
        int guessCounter;

        do {
            guessCounter = 0;
            Console.Write("What is the Magic Number? \n");
            string strMN = Console.ReadLine();
            int magicNumber = int.Parse(strMN);
            bool currentGameActive = true;
            do{
                Console.Write("What is your guess? \n");
                string strGuess = Console.ReadLine();
                int guess = int.Parse(strGuess);
                guessCounter++;
                if (guess < magicNumber){
                    Console.WriteLine("Your guess is Low");
                }
                else if (guess > magicNumber){
                    Console.WriteLine("Your guess is High");
                }
                else {
                    currentGameActive = false;
                }
            } while (currentGameActive);
            Console.WriteLine($"You guessed it! It took you {guessCounter} guesses. \n");
            Console.Write("Do you want to go again? (enter Y or N)  \n");
            string again = Console.ReadLine();
            if (again == "Y"){
                active = true;
            }
            else if (again == "N"){
                active = false;
            }
            else{
                Console.WriteLine("Incorrect Response, Assuming not continuing");
            }

        } while (active);
        
    }
}
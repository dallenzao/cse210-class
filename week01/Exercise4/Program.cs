using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of Numbers, Type 0 when finished.\n");
        int numToAdd;
        do{
            Console.Write("Enter Number: ");
            string strNumToAdd = Console.ReadLine();
            numToAdd = int.Parse(strNumToAdd);
            if (numToAdd != 0){
                numbers.Add(numToAdd);
            }
        } while (numToAdd!=0);
        
        int sum = 0;
        int max = numbers[0];
        int smallestPos = 0;
        for (int i = 0; i < numbers.Count; i++){
            sum += numbers[i];
            if (max < numbers[i]){
                max = numbers[i];
            }
            if (numbers[i] > 0){
                if (smallestPos == 0){
                    smallestPos = numbers[i];
                }
                else if (numbers[i] < smallestPos)
                smallestPos = numbers[i];
            }
        }
        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPos}");
    }

}
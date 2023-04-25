using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

    List<int> numbers;
    numbers = new List<int>();
    int NewUserNumber = 0;

        do
        {
        // Getting input from User
        Console.Write("Please give us a number. (enter 0 to end the program): ");
        NewUserNumber = int.Parse(Console.ReadLine());

        // Adding the input to a list
        numbers.Add(NewUserNumber);
        
        // looping through until the user enters 0
        }while (NewUserNumber != 0);

    int SumNumbers = 0;

    // Calculating the Sum
    foreach (int UserNumber in numbers)
    {
        SumNumbers += UserNumber;
    }

    // Displaying the Sum
    Console.WriteLine($"The Sum is: {SumNumbers}");

    // Calculating the average
    int iterations = 0;
    foreach (int UserNumber in numbers)
    {
        iterations++;
    }

    int AverageNumbers = (SumNumbers / iterations);

    // Displaying the Average
    Console.WriteLine($"The Average is {AverageNumbers}");

    // Calculating the highest number that was entered
    int HighestNumber = 0;
    foreach (int UserNumber in numbers)
    {
        if (UserNumber > HighestNumber){
            HighestNumber = UserNumber;
        }
    }
    // Showing the highest number to the user
    Console.WriteLine($"The Highest Number you entered is: {HighestNumber}");
    }
}
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
        Console.Write("Please give us a number. (enter 0 to end the program): ");
        NewUserNumber = int.Parse(Console.ReadLine());

        numbers.Add(NewUserNumber);
        }while (NewUserNumber != 0);

    int SumNumbers = 0;

    foreach (int UserNumber in numbers)
    {
        SumNumbers += UserNumber;
    }

    Console.WriteLine($"The Sum is: {SumNumbers}");

    int iterations = 0;
    foreach (int UserNumber in numbers)
    {
        iterations++;
    }

    int AverageNumbers = (SumNumbers / iterations);

    Console.WriteLine($"The Average is {AverageNumbers}");

    int HighestNumber = 0;
    foreach (int UserNumber in numbers)
    {
        if (UserNumber > HighestNumber){
            HighestNumber = UserNumber;
        }
    }

    Console.WriteLine($"The Highest Number you entered is: {HighestNumber}");
    }
}
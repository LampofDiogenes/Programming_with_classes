using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to the Program!");

        Console.Write("What is your name? ");
        string UserName = Console.ReadLine();

        Console.Write("What is you favorite Number? ");
        int FavoriteNumber = int.Parse(Console.ReadLine());

        int FavoriteNumberSquared = (FavoriteNumber * FavoriteNumber);

        Console.Write($"Hello {UserName}, your favorite number squared is {FavoriteNumberSquared}.");

    }
}
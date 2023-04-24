using System;


// learning activity: loops

namespace absolutely{
    class Program
    {
        static void Main(string[] args)
        {

            Random RandomNumberGenerator = new Random();

            //Console.Write("Please input the magic number: ");
            //string MagicInput = Console.ReadLine();
            //int MagicNumber = int.Parse(MagicInput);
            int MagicNumber = RandomNumberGenerator.Next(1,100);
            string UserGuess = "";
            int UserNumber = 0;
            int NumberOfGuesses = 0;
            do
            {
            Console.WriteLine("I am thinking of a real number.");
            Console.Write("What is your guess? ");
            UserGuess = Console.ReadLine();
            UserNumber = int.Parse(UserGuess);

            if (UserNumber == MagicNumber){
                Console.WriteLine("That's it!");
            }
            else if (UserNumber > MagicNumber){
                Console.WriteLine("Lower");
            }
            else if (UserNumber < MagicNumber){
                Console.WriteLine("Higher");
            }

            NumberOfGuesses++;
            Console.WriteLine();
            } while (MagicNumber != UserNumber);

            Console.WriteLine($"You guessed {NumberOfGuesses} Times.");
        }
    }
}
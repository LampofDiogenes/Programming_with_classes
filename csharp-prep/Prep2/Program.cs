using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Please input your grade: ");
        string GradeInput = Console.ReadLine();

        int GradeNumber = int.Parse(GradeInput);

        
        if (GradeNumber >= 90) {
            string GradeLetter = "A";
            Console.WriteLine($"Passed! You got this grade: {GradeLetter}");
        }
        else if (GradeNumber >= 80) {
            string GradeLetter = "B";
            Console.WriteLine($"Passed! You got this grade: {GradeLetter}");
        }
        else if (GradeNumber >= 70) {
            string GradeLetter = "C";
            Console.WriteLine($"Passed! You got this grade: {GradeLetter}");
        }
        else if (GradeNumber >= 60) {
            string GradeLetter = "D";
            Console.WriteLine($"Failed. Better luck next time. Grade: {GradeLetter}");
        }
        else if (GradeNumber < 60 || GradeNumber > 0) {
            string GradeLetter = "F";
            Console.WriteLine($"Failed. Better luck next time. Grade: {GradeLetter}");
        }
        else{
            
            Console.WriteLine($"Something strange Happened. Make sure your value was between 0 and 100.");
        }
    }
}
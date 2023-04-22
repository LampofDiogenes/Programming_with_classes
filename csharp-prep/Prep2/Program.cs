using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Please input your grade: ");
        string GradeInput = Console.ReadLine();

        int GradeNumber = int.Parse(GradeInput);
        string Letter = "";
        string sign = "";
        
        if (GradeNumber >= 90) {
            Letter = "A";
        }
        else if (GradeNumber >= 80) {
            Letter = "B";
        }
        else if (GradeNumber >= 70) {
            Letter = "C";
        }
        else if (GradeNumber >= 60) {
            Letter = "D";
        }
        else if (GradeNumber < 60 && GradeNumber >= 0) {
            Letter = "F";
        }
        else{
            
            Console.WriteLine($"Something strange Happened. Make sure your value was between 0 and 100.");
        }

        if (GradeNumber%10 >= 7 && Letter != "A" && Letter != "F") {
            sign = "+";
        }
        else if (GradeNumber%10 <= 3 && Letter != "F") {
            sign = "-";
        }
        else {
            sign = "";
        }


        Console.WriteLine($"Excellent! You grade was: {Letter}{sign}.");
    }
}
using System;

class Program
{
    static void Main()
    {
        Assignment homework = new Assignment();

        // Clearing annoying text
        Console.Clear();

        // grabing data from Assignment to use as variables in main
        homework.SetStudentName("Karl");
        homework.SetSubject("Literature");

        string _studentName = homework.GetStudentName();
        string _topic = homework.GetTopic();

        string report = homework.GetSummary();
        
        Console.WriteLine(report);

        WritingAssignment Book = new WritingAssignment();
        Book.SetWritingInformation("Farenheit 451", "Ray Bradbury");
        string book1 = Book.GetWritingInformation();
        Console.WriteLine(book1);

        Console.WriteLine();

        homework.SetStudentName("Fallisha");
        homework.SetSubject("Physics");
        _studentName = homework.GetStudentName();
        _topic = homework.GetTopic();
        string FallishaInfo = homework.GetSummary();

        MathAssignent MathHomework = new MathAssignent();
        MathHomework.SetHomeworkList("Section 9.9", "Problems 1-10");
        string WednesdayHomework = MathHomework.GetHomeworkList();

        Console.WriteLine(FallishaInfo);
        Console.WriteLine(WednesdayHomework);
    }
    
}
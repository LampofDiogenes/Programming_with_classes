using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning World!");
    }
}

public class Job
{

public static void DisplayJob(string[] jobtitle, string[] company, int[] StartYear, int[] EndYear)
    {
        Console.WriteLine($"{jobtitle} ({company} {StartYear} {EndYear})");
    }
}

public class Resume
{

}
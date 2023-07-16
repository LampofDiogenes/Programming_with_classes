using System;

class Program
{
    static void Main()
    {
        Swimming Swimming1 = new Swimming();
        Running Running1 = new Running();
        Cycling Cycling1 = new Cycling();

        Swimming1.SetDate("03 Nov 2022");
        Running1.SetDate("03 Nov 2022");
        Cycling1.SetDate("03 Nov 2022");

        // The stuff I get from the user
        Swimming1.SetTime(30);
        Swimming1.SetLaps(50);

        Running1.SetTime(60);
        Running1.SetDistance(2);

        Cycling1.SetTime(150);
        Cycling1.SetSpeed(15);
        

        // The stuff the app needs to figure out
        Swimming1.FindDistance();
        Swimming1.FindSpeed();
        Swimming1.FindPace();

        Running1.FindSpeed();
        Running1.FindPace();

        Cycling1.FindDistance();
        Cycling1.FindPace();

        Console.WriteLine($"{Cycling1.GetTime()}");
        Console.WriteLine($"{Cycling1.GetSpeed()}");
        Console.WriteLine($"{Cycling1.GetDistance()}");

            // Swimming1.SetLaps(50);
            // Swimming1.FindDistance();
            // Running1.SetDistance(2);
            // Cycling1.SetDistance(3);

            // Console.WriteLine(Swimming1.GetDistance());

            // Swimming1.SetTime(180);
            // Running1.SetTime(120);
            // Cycling1.SetTime(60);

            // Console.WriteLine(Swimming1.GetTime());

            // Swimming1.FindSpeed();
            // Running1.FindSpeed();
            // Cycling1.FindSpeed();

            // Console.WriteLine($"{Swimming1.FindSpeed()}");

            // Swimming1.FindPace();
            // Running1.FindPace();
            // Cycling1.FindPace();


        List<Activity> activityList = new List<Activity>();
        activityList.Add(Swimming1);
        activityList.Add(Running1);
        activityList.Add(Cycling1);

        Console.WriteLine();
        foreach (Activity activity in activityList)
        {
            Console.WriteLine($"{activity.MakeSummary()}");
        }
        Console.WriteLine();
    }
}
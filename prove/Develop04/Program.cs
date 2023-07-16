using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        // creating activities

        Breathing breathing1 = new Breathing();
        Listing listing1 = new Listing();
        Reflection reflection1 = new Reflection();
        
        



        //Menu System variables
        Boolean Continue = true;
        string activitySelection;
        Activity activity = new Activity();
        string activityDuration;

        while (Continue is true)
        {
            Console.WriteLine("Hello! We have 3 activities to choose from. Please select one.");
            Console.WriteLine("[1] Breathing");
            Console.WriteLine("[2] Listing");
            Console.WriteLine("[3] Reflection");
            Console.WriteLine("[4] Quit");
            activitySelection = Console.ReadLine();

            if (activitySelection is "1")
            {
                activity = breathing1;
            }
            else if(activitySelection is "2")
            {
                activity = listing1;
            }
            else if(activitySelection is "3")
            {
                activity = reflection1;
            }
            else if(activitySelection is "4")
            {
                Continue = false;
                break;
            }
            Console.Clear();
            // telling the user what the activity is and a description
            Console.WriteLine(activity.StartingMessage());
            Console.WriteLine();
            Console.WriteLine("How Long, in Seconds, do you want this excersize to last?");
            activityDuration = Console.ReadLine();


            // Telling the user they did a good job
            Console.WriteLine($"Great Work!");
            activity.PauseTime(2);
            Console.WriteLine($"You have completed: {activity}");
            Console.WriteLine($"You have done this for [not coded] seconds!");
            activity.PauseTime(4);
            Console.Clear();
        }

    }
}
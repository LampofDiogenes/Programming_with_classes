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

        // adding the prompts for reflection
        reflection1.AddMainPrompt("Think of a time when you stood up for someone else.");
        reflection1.AddMainPrompt("Think of a time when you did something really difficult.");
        reflection1.AddMainPrompt("Think of a time when you helped someone in need.");
        reflection1.AddMainPrompt("Think of a time when you did something truly selfless.");

        reflection1.AddDeepeningQuestion("Why was this experience meaningful to you?");
        reflection1.AddDeepeningQuestion("Have you ever done anything like this before?");
        reflection1.AddDeepeningQuestion("How did you get started?");
        reflection1.AddDeepeningQuestion("How did you feel when it was complete?");
        reflection1.AddDeepeningQuestion("What made this time different than other times when you were not as successful?");
        reflection1.AddDeepeningQuestion("What is your favorite thing about this experience?");
        reflection1.AddDeepeningQuestion("What could you learn from this experience that applies to other situations?");
        reflection1.AddDeepeningQuestion("What did you learn about yourself through this experience?");
        reflection1.AddDeepeningQuestion("How can you keep this experience in mind in the future?");

        // adding prompts for listing activity
        
        listing1.AddPrompt("Who are people that you appreciate?");
        listing1.AddPrompt("What are personal strengths of yours?");
        listing1.AddPrompt("Who are people that you have helped this week?");
        listing1.AddPrompt("When have you felt the Holy Ghost this month?");
        listing1.AddPrompt("Who are some of your personal heroes?");


        //Menu System variables
        Boolean Continue = true;
        string activitySelection;
        Activity activity = new Activity();
        int activityDuration;
        string readresponse;

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
            readresponse = Console.ReadLine();
            activityDuration = int.Parse(readresponse);

            if (activitySelection is "1")
            {
                // activity for breathing
                breathing1.BreathingExcersize(activityDuration);
            }
            else if(activitySelection is "2")
            {
                // activity for listing
                listing1.ListingActivity(activityDuration);
            }
            else if(activitySelection is "3")
            {
                // activity for reflection
                reflection1.ReflectionActivity(activityDuration);
            }


            // Telling the user they did a good job
            Console.WriteLine($"Great Work!");
            activity.PauseTime(2);
            Console.WriteLine($"You have completed: {activity}");
            Console.WriteLine($"You have done this for {activityDuration}seconds!");
            activity.PauseTime(4);
            Console.Clear();
        }

    }
}
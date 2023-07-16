using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //Menu System
        string Continue = "y";
        string activitySelection = "";

        while (Continue is "y")
        {
            Console.WriteLine("Hello! We have 3 activities to choose from. Please select one.");
            Console.WriteLine("[1] Breathing");
            Console.WriteLine("[2] Listing");
            Console.WriteLine("[3] Reflection");
            activitySelection = Console.ReadLine();

            if (activitySelection is "1")
            {

            }
            else if(activitySelection is "2")
            {

            }
            else if(activitySelection is "3")
            {
                
            }


            // Determining whether to continue or not
            Console.WriteLine("Enter 'y' to continue, or anything else to quit");
            Continue = Console.ReadLine();
        }

    }
}
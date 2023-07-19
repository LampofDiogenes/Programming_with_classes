using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // creating objects
        Checklist pushUps = new Checklist();
        Simple marathon = new Simple();
        Eternal readScriptures = new Eternal();

        List<Goal> goalList = new List<Goal>();
        int pointTotal = 0;
        string goalType;

        // Setting Parameters
        pushUps.SetFinishLine(3);
        pushUps.SetPointValue(1000);

        marathon.SetPointValue(10000);
        readScriptures.SetPointValue(100);

        
        goalList.Add(pushUps);
        goalList.Add(marathon);
        goalList.Add(readScriptures);

        string choseOption = "1";
        // creating the for loop
        Console.WriteLine();
        while (choseOption is not "5")
        {
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine("[1] Check off a goal");
            Console.WriteLine("[2] See your Point Total");
            Console.WriteLine("[3] Add A Goal");
            Console.WriteLine("[4] Save your Data");
            Console.WriteLine("[5] Quit");
            choseOption = Console.ReadLine();

            // making console readable
            Console.Clear();
            Console.WriteLine();


            if (choseOption is "1")
            {
                int goalNumber = 0;
                foreach (Goal goal in goalList)
                {
                    Console.WriteLine($"[{goalNumber + 1}] {goal}: {goal.ShowCompletion()}");  
                    goalNumber += 1;
                }
                Console.WriteLine();
                Console.WriteLine("which goal do you want to check off?");
                string goalSelection = Console.ReadLine();
                int chosenGoal = Int32.Parse(goalSelection);
                goalList[chosenGoal - 1].GoalCompleted();
                pointTotal += goalList[chosenGoal].PointsRecieved();
            }
            else if (choseOption is "2")
            {
                Console.WriteLine(pointTotal);
            }
            else if (choseOption is "3")
            {
                Console.WriteLine("Which type of Goal is it?");
                Console.WriteLine("[1] Simple");
                Console.WriteLine("[2] Eternal");
                Console.WriteLine("[3] Checklist");
                goalType = Console.ReadLine();
                if (goalType is "1")
                {
                    Simple userGoal = new Simple();
                                        
                    Console.WriteLine("How Many Points is it Worth?");
                    int pointValue = Int32.Parse(Console.ReadLine());
                    userGoal.SetPointValue(pointValue);
                }
                else if (goalType is "2")
                {
                    Eternal userGoal = new Eternal();
                                        
                    Console.WriteLine("How Many Points is it Worth?");
                    int pointValue = Int32.Parse(Console.ReadLine());
                    userGoal.SetPointValue(pointValue);
                }
                else if (goalType is "3")
                {
                    Checklist userGoal = new Checklist();
                    
                    Console.WriteLine("How Many Points is it Worth?");
                    int pointValue = Int32.Parse(Console.ReadLine());
                    userGoal.SetPointValue(pointValue);
                } 

            }
            else if (choseOption is "4")
            {

            }
            else if (choseOption is "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
            Console.WriteLine();
        }
    }
}
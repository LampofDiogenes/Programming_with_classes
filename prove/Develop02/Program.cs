using System;
using System.Collections.Generic;

class Entry
{
    string UnsavedData = "";
    string SavedData = "";
    public string StoreString()
    {
        UnsavedData = Console.ReadLine();
        return UnsavedData;
    }
    public void DisplayEntry(string display)
    {
        Console.WriteLine(display);
    }
}
class Prompt
{
    List<string> PromptCollection = new List<string>();
    string InspirationalMessage;

    public void DisplyRandomPrompt()
    {
        Random inspiration = new Random();

        PromptCollection.Add("What was your favorite meal today?");
        PromptCollection.Add("Name something that you are proud of today");
        PromptCollection.Add("Name a regret you want to improve upon in the future");
        PromptCollection.Add("Name something you are grateful for");
        PromptCollection.Add("Name an interaction that you thought was notable");


        Random rnd = new Random();
        int RandomNumber = rnd.Next(0,4);
        string SelectRandomPrompt = PromptCollection[RandomNumber];

        Console.WriteLine(SelectRandomPrompt);

    }
}

class ProgramRunning{
    public void Main(string[] args)
    {
        // find what the user wants
        Console.WriteLine("Hello. Please Select from the options: ");
        Console.WriteLine("1. Write a New Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");

        string UserCommand = Console.ReadLine();

        // writing a new journal entry
        if (UserCommand is "1"){
            Prompt NewPrompt = new Prompt();
            NewPrompt.DisplyRandomPrompt();
        
            string NewEntry = Console.ReadLine();
        }

        else if (UserCommand is "3"){
            


        }

    }
}
using System;
using System.Collections.Generic;
using System.IO;

class Entry
{


    public void StoreString(string UnsavedData, string FilePath)
    {
        // Read the "entry" that the user gave.
        UnsavedData = Console.ReadLine();


        // Dumping the information of the user into the filename
        using (StreamWriter writer = new StreamWriter(FilePath)){
            
            // Data to be Dumped
            Console.WriteLine(UnsavedData);
        }
        // Telling User task accomplished
        Console.WriteLine("Data Saved. ");
        
    }
    public void DisplayEntry(string display)
    {
        Console.WriteLine(display);

    }
}
class Prompt
{
    List<string> PromptCollection = new List<string>();

    public void DisplyRandomPrompt()
    {
        Random inspiration = new Random();

        // Adding prompts for the prompt generator to push
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
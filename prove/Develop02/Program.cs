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

        int NumberOfPrompts = PromptCollection.Count;

    }
}
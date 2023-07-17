using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime;
using System.Threading;

class Reflection : Activity
{
    List<string> _MainPrompt = new List<string>();
    List<string> _deepeningQuestions = new List<string>();
    Random _rand = new Random();
    int _promptQuantity;

    public void AddMainPrompt(string prompt)
    {
        _MainPrompt.Add(prompt);
    }
    public void AddDeepeningQuestion(string prompt)
    {
        _deepeningQuestions.Add(prompt);
    }

    public override void DefaultActivityName()
    {
        _activityName = "reflection";
    }
    public override void DefaultActivityDescription()
    {
        _activityDescription = @"This is an activity to reflect on details about 
    an experience where you demonstrated strength";
    }

    public string FindRandomPrompt(List<string> promptList)
    {
        
        // find the amount of prompts in the list
        _promptQuantity = promptList.Count();

        // use the random number to call a specific prompt in the list
        int _randomNumber = _rand.Next(_promptQuantity);
        string _randomPrompt = promptList[_randomNumber];
        
        return _randomPrompt;
    }

    public void ReflectionActivity(int activityDuration)
    {
        Console.Clear();
        
        // Give the First General Prompt
        Console.WriteLine(FindRandomPrompt(_MainPrompt));
        
        PauseTime(2);
        int timeTaken = 4;

        while (timeTaken <= activityDuration)
        {
        // Give Deepening Questions
        Console.Clear();
        Console.WriteLine(FindRandomPrompt(_deepeningQuestions));
        PauseTime(2);
        timeTaken += 4;
        Console.Clear();
        }
    }



}
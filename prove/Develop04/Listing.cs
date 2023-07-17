using System;
using System.Linq;
using System.Collections.Generic;

class Listing : Activity
{
    // variables
    List<string> _promptList = new List<string>();
    Random _rand = new Random();
    string _listedItem;
    List<string> _userList = new List<string>();
    int _QuanitityOfItems;
    DateTime _startTime;
    DateTime _endTime;


    // Methods
    public void AddPrompt(string prompt)
    {
        _promptList.Add(prompt);
    }
    public override void DefaultActivityName()
    {
        _activityName = "Listing";
    }
    public override void DefaultActivityDescription()
    {
        _activityDescription = @"This is an activity to list as many strengths 
    in an area as you can in a specific time.";
    }


    public string FindRandomPrompt(List<string> promptList)
    {
        
        // find the amount of prompts in the list
        int _promptQuantity = promptList.Count();

        // use the random number to call a specific prompt in the list
        int _randomNumber = _rand.Next(_promptQuantity);
        string _randomPrompt = promptList[_randomNumber];
        
        return _randomPrompt;
    }
    public void ListingActivity(int activityDuration)
    {
        // print a random prompt in the _promptList
        Console.WriteLine(FindRandomPrompt(_promptList));
        Console.WriteLine();
        PauseTime(2);
        Console.WriteLine();

        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(activityDuration);


        
        while (_startTime <= _endTime)
        {
            _listedItem = Console.ReadLine();
            
            if (_startTime >= _endTime)
            {
                break;
            }
            
            _userList.Add(_listedItem);
            _QuanitityOfItems += 1;
            _startTime = DateTime.Now;
            
        }
        Console.WriteLine("Time's Up!");
        PauseTime(2);
        Console.WriteLine($"You entered: {_QuanitityOfItems} items");
    }
}
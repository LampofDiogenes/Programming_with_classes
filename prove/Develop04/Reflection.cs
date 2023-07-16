using System;
using System.Linq;
using System.Collections.Generic;

class Reflection : Activity
{
    List<string> _reflectionPrompts;
    string _prompt;

    public override void DefaultActivityName()
    {
        _activityName = "reflection";
    }
    public override void DefaultActivityDescription()
    {
        _activityDescription = @"This is an activity to reflect on details about 
    an experience where you demonstrated strength";
    }


    public List<string> GetReflectionPrompts()
    {
        return _reflectionPrompts;
    }

    public void SetReflectionPrompts(List<string> value)
    {
        _reflectionPrompts = value;
    }

    // Getter and Setter for _prompt
    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

}
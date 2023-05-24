using System;
using System.Collections.Generic;

class reference{

    string verse = "John 3:16";

    private string ScriptureMap(string listOfWords, string verse){

        Dictionary<string, string> ScriptureMapping = new Dictionary<string, string>();

        ScriptureMapping[verse] = listOfWords;

        return ScriptureMapping[verse];
    }

    public string constructor(Dictionary<string, string> ScriptureMapping){

        return ScriptureMapping[verse];
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ScriptureMemorize{

    class Scripture
    {
        string _reference;
        public List<string> ConvertScripture(string[] args)
        {
            List<string> ListOfWords = _reference?.Split(" ").ToList();

            return ListOfWords;
        }
    }

}
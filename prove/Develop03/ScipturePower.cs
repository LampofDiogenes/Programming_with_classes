using System;
using System.Linq;
using System.Collections.Generic;
    class Scripture
    {
        string _reference = @"For God so loved the world, that he gave his only begotten Son, that whosoever 
        believeth on him should not perish, but have eternal life";
        private List<string> ConvertScripture(string[] args)
        {
            List<string> ListOfWords = _reference?.Split(" ").ToList();

            return ListOfWords;
        }
    }
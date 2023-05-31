using System;
using System.Linq;
using System.Collections.Generic;
    class Scripture
    {
        private string _reference = @"For God so loved the world, that he gave his only begotten Son, that whosoever 
        believeth on him should not perish, but have eternal life";
        private List<string> ListOfWords;
        public void ConvertScripture()
        { //List<string> ListOfWords
            ListOfWords = _reference?.Split(" ").ToList();
        }

        public List<string> ShowScripture(){
            return ListOfWords;
        }
    }
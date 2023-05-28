using System;
using System.Collections.Generic;
class ManageWords{
    private int FindRandomWord(){

        Random rand = new Random();


        return rand.Next(25);
    }

    private List<int> FindThreeRandomWords(int WordPlace){
            int Word1 = FindRandomWord();
            int Word2 = FindRandomWord();
            int Word3 = FindRandomWord();

            List<int> RandomWords = new List<int>();

            RandomWords.Add(Word1);
            RandomWords.Add(Word2);
            RandomWords.Add(Word3);

            return RandomWords;
    

    }

    public List<string> DeleteRandomWords(List<string> ScriptureVerse){

        Random Rand = new Random();
        int RandomIndex = Rand.Next(ScriptureVerse.Count);

        for (int i = 0; i < 3; i++)
        {
        ScriptureVerse[RandomIndex] = "___";
        }
        return ScriptureVerse;
    }
}
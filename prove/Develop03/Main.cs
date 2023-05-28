using System;
using System.Linq;
using System.Collections.Generic;

    class Program{
        List<string> Verse = Scripture.ShowScripture();

        public void main(){
            Console.WriteLine("The Verse is :");
            Console.WriteLine(Verse);
            Console.WriteLine("Type Enter or Quit when done. ");
            string QuitOrNOt = Console.ReadLine();

            while (QuitOrNOt != "Quit") 
            {
                if  ((QuitOrNOt is "Quit"))
                {
                    Console.Clear();
                }
            else if (QuitOrNOt is "Enter")
                {
                    Console.Clear();
                    List<string> NewScripture = ManageWords.DeleteRandomWords(Scripture.ShowScripture());

                    Console.WriteLine(NewScripture);
                }
            }


        }




}


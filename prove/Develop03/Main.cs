using System;
using System.Linq;
using System.Collections.Generic;

    class Program{
        
        
        
        
        

        static void Main(){

            // Moved Constructors to underneath main. Works now, I guess
            List<string> ScriptureInMain;
            Words Karen = new Words(); 
            Scripture power = new Scripture();
            power.ConvertScripture();
            ScriptureInMain = power.ShowScripture();
            Console.WriteLine("The Verse is :");

            // printing each word individually
            foreach (string i in ScriptureInMain)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Type Enter or Quit when done. ");
            string QuitOrNOt = Console.ReadLine();

            while (QuitOrNOt is "Quit" || QuitOrNOt is "Enter")
            {
                if  ((QuitOrNOt is "Quit"))
                {
                    Console.Clear();
                }
                else if (QuitOrNOt is "Enter")
                {
                    Console.Clear();
                    List<string> NewScripture = Karen.DeleteRandomWords(ScriptureInMain);

                    foreach (string word in NewScripture)
                    {
                        Console.Write(word + " ");
                    }
                }
                
                Console.WriteLine();
                Console.WriteLine("Type Enter or Quit when done. ");
                QuitOrNOt = Console.ReadLine();
            }
        }
}


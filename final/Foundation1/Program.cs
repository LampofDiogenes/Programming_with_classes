using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
    // Setting Up Variables
        Video YouTube1 = new Video();
        Video YouTube2 = new Video();
        Video YouTube3 = new Video();

        YouTube1.SetTitle("Words");
        YouTube2.SetTitle("Letters");
        YouTube3.SetTitle("The Alphabet");

        YouTube1.SetAuthor("PewdiePie");
        YouTube2.SetAuthor("Jacksepticeye");
        YouTube3.SetAuthor("Markiplier");

        YouTube1.SetSeconds(394);
        YouTube2.SetSeconds(906);
        YouTube3.SetSeconds(8673);

        // Comments YouTube1
        Comment Comment1_1 = new Comment();
            Comment1_1.SetAuthor("Steven");
            Comment1_1.SetComment("Bruh this sucks");
        
        Comment Comment1_2 = new Comment();
            Comment1_2.SetAuthor("Brim");
            Comment1_2.SetComment("I Hope this Works");

        Comment Comment1_3 = new Comment();
            Comment1_3.SetAuthor("Johnny");
            Comment1_3.SetComment("Ha! It works! YESSSSSS");


        // Comments YouTube2
        Comment Comment2_1 = new Comment();
            Comment2_1.SetAuthor("Charizard");
            Comment2_1.SetComment("LET's GO!!!!!!");

        Comment Comment2_2 = new Comment();
            Comment2_2.SetAuthor("23andSingle");
            Comment2_2.SetComment("I think this might be my first working code");

        Comment Comment2_3 = new Comment();
            Comment2_3.SetAuthor("Hater96");
            Comment2_3.SetComment("Pff. Could do in my sleep.");


        // Comments YouTube3
        Comment Comment3_1 = new Comment();
            Comment3_1.SetAuthor("demomanTF2");
            Comment3_1.SetComment("ad;fiohfnnalklcvfz");
        Comment Comment3_2 = new Comment();
            Comment3_2.SetAuthor("Dad");
            Comment3_2.SetComment("Son, I got the milk. We can finally be a family");
        Comment Comment3_3 = new Comment();
            Comment3_3.SetAuthor("23Guns_and_a_nickel");
            Comment3_3.SetComment("FBI loves me, my wallet hates me.");

        YouTube1.StoreComment(Comment1_1);
        YouTube1.StoreComment(Comment1_2);
        YouTube1.StoreComment(Comment1_3);

        YouTube2.StoreComment(Comment2_1);
        YouTube2.StoreComment(Comment2_2);
        YouTube2.StoreComment(Comment2_3);

        YouTube3.StoreComment(Comment3_1);
        YouTube3.StoreComment(Comment3_2);
        YouTube3.StoreComment(Comment3_3);
        

        // Will not add any information about YouTube(X) after this runs.
        List<Video> allVideos = new List<Video>();
        allVideos.Add(YouTube1);
        allVideos.Add(YouTube2);
        allVideos.Add(YouTube3);


    // Running Code
        Console.WriteLine();
        foreach (Video Video in allVideos)
        {
            Console.WriteLine($"The Author for '{Video.GetTitle()}' is {Video.GetAuthor()}");
            Console.WriteLine($"The Video is {Video.GetSeconds()} Seconds Long");
            foreach (Comment comment in Video.ShowComments())
            {
                Console.WriteLine();
                Console.WriteLine($"Comment Author: {comment.GetAuthor()}");
                Console.WriteLine($"Comment Content: {comment.GetComment()}");
                Console.WriteLine();
            }
            Console.WriteLine();

        }




        
    }
}
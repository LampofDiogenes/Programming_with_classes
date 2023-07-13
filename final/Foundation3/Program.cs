using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        Address Location = new Address("1946 Charles Bent", "Blackfoot", "Utah", "USA");
        string LocationTitle = Location.FullAddress();
        Lecture Lecture1 = new Lecture("The Fundamentals of Psychology", "Jordan Peterson", "200", "an introductory class for beginners", "09-14-2027","4:00", Location);
        
        List<string> registeredPeople = new List<string>();
        registeredPeople.Add("Pastor");
        registeredPeople.Add("Man A");
        registeredPeople.Add("Woman B");
        registeredPeople.Add("Parent of Woman B");
        registeredPeople.Add("Parent of Man A");
        foreach (string person in registeredPeople)
        {
          Console.WriteLine(person);
        }
        

        Reception Reception1 = new Reception("Marriage of 2 People", "Today we Celebrate the union of Man A and Woman B", registeredPeople, "03-23-2029", "3:30", Location);

        Outdoor hunting1 = new Outdoor("Moose Hunting", "Gonna go out and hunt us some meese", "08-09-2023", "5:00am", Location, "Sunny");

        List<Event> eventList = new List<Event>();
        eventList.Add(Lecture1);
        eventList.Add(Reception1);
        eventList.Add(hunting1);
        
        Reception1.CombineList();

        foreach (Event Event in eventList)
        {
            Console.WriteLine();
            Event.EventType();
            Console.WriteLine($" The Short description: {Event.ShortDescription()}");
            Console.WriteLine($" Here are the Standard Details: {Event.StandardDetails()}");
            Console.WriteLine($" !!!!!!!!!!!!!Here are the full Details: ");
            
            Console.WriteLine(Event.FullDetails());
        }
        Console.WriteLine();
    }
}
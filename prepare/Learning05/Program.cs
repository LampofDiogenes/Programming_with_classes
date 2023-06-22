using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Creating Square s
        square s = new square(5, "red");
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());

        // Creating Rectange r
        rectangle r = new rectangle(5, 6, "purple");
        
        // Creating Circle c
        circle c = new circle(1.5, "blue");

        List<shape> ShapeList = new List<shape>();

        ShapeList.Add(s);
        ShapeList.Add(r);
        ShapeList.Add(c);

        foreach (shape item in ShapeList)
        {
            Console.WriteLine(item.GetArea());
            Console.WriteLine(item.GetColor());
        }
    }
}
using System;
using TriangleTracker;


class TriangleUI{
    static void Main(){
        Console.Clear();
        Console.WriteLine("Please enter the length of a triangle for side a:");
        string stringA = Console.ReadLine();
        int a = int.Parse(stringA);
        Console.Clear();
        Console.WriteLine("Please enter the length of a triangle for side b:");
        string stringB = Console.ReadLine();
        int b = int.Parse(stringB);
        Console.Clear();
        Console.WriteLine("Please enter the length of a triangle for side c:");
        string stringC = Console.ReadLine();
        int c = int.Parse(stringC);
        Triangle newTriangle = new Triangle();
        if (newTriangle.IsValidTriangle(a,b,c)){
            Console.Clear();
            Console.WriteLine(newTriangle.GetTriangleType(a,b,c));
        } else {
            Console.Clear();
            Console.WriteLine("Your triangle isn't a triangle.");
        }
    }
}
using System;
using CircleMethods;

System.Console.WriteLine("Enter a radius: ");
double radius = double.Parse(Console.ReadLine());


System.Console.WriteLine("Area of a circle with that radius: " + Circle.Area(radius));
System.Console.WriteLine("Circumference of a circle with that radius: " + Circle.Circumference(radius));
System.Console.WriteLine("Diameter of a circle with that radius: " + Circle.Diameter(radius));


System.Console.WriteLine("What MPG does your car get? ");
double milePerGallon = double.Parse(Console.ReadLine());
double gallonsUsed = Circle.Circumference(radius) / milePerGallon;
System.Console.WriteLine("You'll use " + gallonsUsed + " gallons of fuel to drive in that circle.");
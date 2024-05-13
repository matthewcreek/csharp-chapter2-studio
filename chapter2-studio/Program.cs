using System;
using CircleMethods;

string input;
double radius;
do
{
    System.Console.WriteLine("Enter a radius: ");
    input = Console.ReadLine();
    if (!double.TryParse(input, out radius))
    {
        Console.WriteLine("Invalid input.");
        return;
    }
} while (input == "" || double.Parse(input) <= 0);



System.Console.WriteLine("Area of a circle with that radius: " + Circle.Area(radius));
System.Console.WriteLine("Circumference of a circle with that radius: " + Circle.Circumference(radius));
System.Console.WriteLine("Diameter of a circle with that radius: " + Circle.Diameter(radius));


System.Console.WriteLine("What MPG does your car get? ");
double milePerGallon = double.Parse(Console.ReadLine());
double gallonsUsed = Circle.Circumference(radius) / milePerGallon;
System.Console.WriteLine("You'll use " + gallonsUsed + " gallons of fuel to drive in that circle.");
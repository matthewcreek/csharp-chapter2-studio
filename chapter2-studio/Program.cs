using System;

System.Console.WriteLine("Enter a radius: ");
double radius = double.Parse(Console.ReadLine());
double areaCircle = Math.Round(Math.PI * Math.Pow(radius, 2), 1);
double circumference = Math.Round(2 * Math.PI * radius, 1);
double diameter = Math.Round(2 * radius, 1);
System.Console.WriteLine("Area of a circle with that radius: " + areaCircle);
System.Console.WriteLine("Circumference of a circle with that radius: " + circumference);
System.Console.WriteLine("Diameter of a circle with that radius: " + diameter);


System.Console.WriteLine("What MPG does your car get? ");
double milePerGallon = double.Parse(Console.ReadLine());
double gallonsUsed = circumference / milePerGallon;
System.Console.WriteLine("You'll use " + gallonsUsed + " gallons of fuel to drive in that circle.");
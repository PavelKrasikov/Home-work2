﻿Console.WriteLine("x1 = : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y1 = : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z1 = : ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("x2 = : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y2 = : ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z2 = : ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow (x2 - x1,2) + Math.Pow (y2 - y1,2) + Math.Pow (z2 - z1,2));
Console.WriteLine("Расстояние между точками = " + distance);

﻿double a, b, c, d, x, y, z, r;
Console.WriteLine("Enter a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter c:");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter d:");
d = double.Parse(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b)
/ (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);

y = 5 * (a + b) * (c - d) / (1.0 / 2 * c) + (Math.Pow(d, 2) *
    (Math.Pow(a, 2) - Math.Pow(b, 2))) / (b - a);

z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) /
    (5 * a + 3 * b);
r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1.0 / (a - c);

Console.WriteLine("X = {0}", x);
Console.WriteLine("Y = {0}", y);
Console.WriteLine("Z = {0}", z);
Console.WriteLine("R = {0}", r);

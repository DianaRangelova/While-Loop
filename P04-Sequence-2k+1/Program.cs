﻿int n = int.Parse(Console.ReadLine());
int i = 1;

while (i <= n)
{
    Console.WriteLine(i);
    i = 2 * i + 1;
}
// with for loop: for (int i = 1; i <= n; i = 2 * i + 1)
// Console.WriteLine(i);
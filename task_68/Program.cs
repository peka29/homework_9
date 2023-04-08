﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}
Console.Clear();
Console.WriteLine($"введите число m = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"введите число n = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(akkerman(n, m));
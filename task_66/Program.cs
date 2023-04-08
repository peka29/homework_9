// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int OutPutNumber(int n, int m)
{
    if (m == 0) return (n * (n + 1)) / 2;            // Если mравно нулю
    else if (n == 0) return (m * (m + 1)) / 2;       // Если n равно нулю
    else if (m == n) return m;                       // Если m=n
    else if (m < n) return n + OutPutNumber(m, n - 1); // Если m<n
    else return n + OutPutNumber(m, n + 1);            // Если m>n
}
Console.Clear();
Console.WriteLine($"введите число m = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"введите число n = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(OutPutNumber(n, m));
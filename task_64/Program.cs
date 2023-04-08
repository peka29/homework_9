// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string OutPutNumber(int number)
{
    if (number == 1)
        return 1.ToString();
    //string Empty = String.Empty;    
   // return OutPutNumber(number - 1)+", " + number.ToString();
   return  number.ToString()+", " + OutPutNumber(number - 1);
}
Console.Clear();
Console.WriteLine($"введите число n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(OutPutNumber(n));
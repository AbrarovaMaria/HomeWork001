// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string Numbers(int start, int end)
{
    if (start >= end) return start.ToString();
    return (start + ", " + Numbers(start + 1, end));
}

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N (больше M): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Натуральные числа в промежутке от M до N: " + Numbers(m, n));

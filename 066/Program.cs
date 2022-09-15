// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

string Numbers(int start, int end)
{
    if (start >= end) return start.ToString();
    return (start + ", " + Numbers(start + 1, end));
}
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N (больше M): ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Натуральные числа в промежутке от M до N: " + Numbers(M, N));

void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        
        Console.WriteLine("Сумма натуральных элементов в промежутке от M до N : " + sum); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}

GapNumberSum(M, N, 0);
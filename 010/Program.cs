//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = (NumberA / 10) % 10;
Console.WriteLine("Вторая цифра вашего числа " + NumberB);
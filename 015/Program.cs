// Задача 15 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели от 1 до 7 ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number == 6 || Number == 7)
{
    Console.WriteLine("ВЫХОДНОЙ");
}
else
{
    Console.WriteLine("Рабочий день");
}
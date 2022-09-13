// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int NumberA)
  {
    int counter = Convert.ToString(NumberA).Length;
    int = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = NumberA - NumberA % 10;
      result = result + (NumberA - advance);
      NumberA = NumberA / 10;
    }
   return result;
  }

int sumNumber = SumNumber(NumberA);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
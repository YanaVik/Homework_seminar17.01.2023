// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a.ToString().Length;


if (b > 3 || b < 3)
{
    Console.WriteLine("Это число не трехзначное");
}

else
{
    Console.WriteLine((a / 10) % 10);
}


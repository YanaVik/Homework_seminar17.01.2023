﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a.ToString().Length;
int divider = Convert.ToInt32(Math.Pow(10, b - 3));

if (b < 3)
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    Console.WriteLine((a / divider) % 10);
}
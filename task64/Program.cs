﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Sum(int num, int limit)
{
    if (limit == num - 1)
    {
        return;
    }
    Console.Write($"{limit} ");
    Sum(num, limit - 1);


}
Console.WriteLine("Enter N");
int N = Convert.ToInt32(Console.ReadLine());
Sum(1, N);
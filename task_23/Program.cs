﻿/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void Cube()
{
    Console.Write("Введите Ваше число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    while (i <= N)
    {
        Console.WriteLine($"{i}: {i*i*i}");
        i++;
    }

}
Cube();
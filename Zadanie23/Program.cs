﻿// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число:");
int chislo = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= chislo)
{
    Console.WriteLine(" " + i*i*i);
    i++;
}
﻿// Упр. 2 (Задача 4): Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Напишите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите третье число: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max)
{
    max = b;
}
else
{
    max = a;
}
if(c > max)
{
    max = c;
}
Console.Write("Максимальное число: ");

Console.Write(max);
﻿//Упр.4(Задача 8): Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Напишите число: ");

int x = Convert.ToInt32(Console.ReadLine());

int y = 1;

while(x >= y)
{
    if(y%2 == 0)
    {
        Console.Write(y );
    }
    else
    {
        Console.Write(" " );
    }
    y = y + 1;
}
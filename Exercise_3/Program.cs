﻿//Упр. 3 (Задача 6): Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Напишите число: ");

int a = Convert.ToInt32(Console.ReadLine());

int z = a%2;

if(z == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
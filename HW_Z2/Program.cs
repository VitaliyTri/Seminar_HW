﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
{
    Console.WriteLine(numberA + " - меньшее число," + " а " + numberB + " - большее");
}
if (numberA > numberB)
{
    Console.WriteLine(numberA + " - большее число," + " а " + numberB + " - меньшее");
}
if (numberA == numberB)
{
    Console.WriteLine("Числа равны!!!");
}
﻿/*
Напишите программу, которая принимает на вход три числа и выдает максимальное из этих трех чисел:
2,3,7 ->7
44,5,78 ->78
22,3,9 ->22
*/

Console.WriteLine("Введите первое число (a):");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число (b):");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число (c):");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

/*
Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее
a=5, b=7 ->max 7
a=2, b=10 -> max 10
a=-9, b=-3 -> max -3
*/


Console.WriteLine("Введите первое число (a):");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число (b):");
int b = int.Parse(Console.ReadLine());

int max = a;

if (a < b) max = b;
Console.WriteLine("max");



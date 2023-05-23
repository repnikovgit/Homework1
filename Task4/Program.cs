/* Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все четные числа от 1 до N
 5 -> 2,4
 8 -> 2,4,6,8
 */

 System.Console.WriteLine("Введите N: ");

int s = int.Parse(Console.ReadLine());

for (int i = 1; i <= s; i++) // или i <= s или i < s+1
{
    if (i % 2 == 0)
    {
        System.Console.Write($"{i} ");
    }
}
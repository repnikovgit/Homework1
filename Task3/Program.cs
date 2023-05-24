/* Напишите программу, которая на вход принимает число и выдает,
 является ли число четным(делится ли оно на 2 без остататка)
 4->lf
 -3 -> нет
 */

System.Console.WriteLine("Введите N: ");

int s = int.Parse(Console.ReadLine());

if (s % 2 == 0){ // остаток от деления на 10
    System.Console.WriteLine("Это четное число");
}
else{
    System.Console.WriteLine("bad");
}
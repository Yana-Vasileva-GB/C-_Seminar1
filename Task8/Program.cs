/*
Домашняя задача 8:
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Я готов показать все чётные числа от 1 до введенного числа. Введи число с клавиатуры:");
int Number = Convert.ToInt32(Console.ReadLine());
int number = 1; 
while (number <= Number)
{
    if (number % 2 == 0)
    {
        Console.Write(number + "| ");
    }
    number++;
}
Console.WriteLine();


/* 
Домашняя Задача 2:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Добрый день! Я помогу найти максимальное и минимальное число из введенных тобой чисел. Давай попробуем!");
Console.WriteLine("Введи первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Максимальное число = " + firstNumber);
    Console.WriteLine("Минимальное число = " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число = " + secondNumber);
    Console.WriteLine("Минимальное число = " + firstNumber);
}

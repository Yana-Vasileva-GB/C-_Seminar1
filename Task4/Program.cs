/* 
Домашняя задача 4:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Привет! Я умею находить максимальное число из трех!");
Console.WriteLine("Последовательно введи с клавиатуры любые три числа");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int threeNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > threeNumber)
    {
        Console.WriteLine("Максимальное число = " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число = " + threeNumber);
    }
}
else
{
    if (secondNumber > threeNumber)
    {
        Console.WriteLine("Максимальное число = " + secondNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число = " + threeNumber);
    }
}
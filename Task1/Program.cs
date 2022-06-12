/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Insert 3-digit number");
int num = int.Parse(Console.ReadLine());

if (num<100 || num>999)
{
    Console.WriteLine("Error. Number isn't 3-digit");
}
else
{
    int secondDigit = (num/10)%10;
    Console.WriteLine($"second digit: {secondDigit}");
}
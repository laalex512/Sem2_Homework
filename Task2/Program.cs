/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Insert number");
int num = int.Parse(Console.ReadLine());

if (num<100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while(num>999)
    {
        num=num/10;
    }
    int thirdDigit=num%10;
    Console.WriteLine($"Third digit: {thirdDigit}");
}
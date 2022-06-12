/*Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

int InsNum(string message)
{
    Console.WriteLine($"Insert {message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num1 = InsNum("number 1");
int num2 = InsNum("number 2");

int num1Square=num1*num1;
int num2Square=num2*num2;

if (num1Square==num2 || num2Square==num1)
{
    Console.WriteLine("Yes");
}    
else 
{
    Console.WriteLine("No");
}

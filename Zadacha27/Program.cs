
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/


Console.WriteLine("Программа подсчёта суммы цифр в числе.");
Console.Write("Введите число: = ");
int a = int.Parse(Console.ReadLine());

int sum = GetSumNumb(a);

Console.WriteLine(sum);

int GetSumNumb(int b)
{
    int sum = 0;
    while (b != 0)
    {
       sum = sum + b % 10;
       b = b /10;

    }

    return sum;
}





/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите число (А) и (В), а программ возведёт число А в степень В");

Console.Write("Введите число: А = ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число: В = ");
int b = int.Parse(Console.ReadLine());

int result = GetSqrAB(a, b);

Console.WriteLine(result);


int GetSqrAB(int a,int b)
{
    int c = a;
    for (int i = 1; i < b; i++)
    {
        a = a * c;

    }

    return a;

}










/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/



Console.Write("Введите длинну массива: ");
int l = int.Parse(Console.ReadLine());
string[] arr = new string[l];

arr = GetArray(l);
PrintArray(arr);



void PrintArray(string[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}]");
}




string[] GetArray(int l)
{
    string[] array = new string[l];
    for (int i = 0; i < l; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
   return array;
}






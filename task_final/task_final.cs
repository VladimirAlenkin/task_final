﻿Console.WriteLine();
Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
string[] str1 = new string[n];
int count = 0;
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите " + (i +1) + " элемент массива");
    str1[i] = Console.ReadLine()!;
    if (str1[i].Length <= 3)
    {
        count++;
    }
}


Console.WriteLine();
Console.WriteLine("Новый массив состоит из " + count + " элементов:");

string[] str2 = new string[count];
int j = 0;
for (int i = 0; i < n; i++)
{
    if (str1[i].Length <= 3)
    {
        str2[j] = str1[i];
        j++;
    }
}

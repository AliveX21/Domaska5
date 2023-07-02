/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(99,999);
        Console.Write(array[i] + " ");
    }
}
int kol(int[] array)
{
    int kol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        kol = kol + 1;
    }
return kol;
}

mas(a);
Console.Write($"\nКоличество чётных чисел в массиве: {kol(array)}");
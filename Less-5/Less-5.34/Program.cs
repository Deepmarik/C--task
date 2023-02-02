/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] FillArray(int lenght, int minValue,int maxValue)
{
    int[] arr = new int[lenght];
    var rnd = new Random();
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    };
    Console.WriteLine($"Количество четных: {count}");
    return arr;
};

void PrintArray(int[] collection)
{
    int position = 0;
    while (position < collection.Length)
    {
        Console.WriteLine(collection[position]);
        position++;
    }
};
PrintArray(FillArray(4,100,999));
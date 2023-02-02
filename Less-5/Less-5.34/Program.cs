/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] FillArray(int lenght)
{
    //Console.WriteLine("Введите длину массива : ");
    //int lenght = int.Parse(Console.ReadLine()!);
    int[] arr = new int[lenght];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
        if (arr[i] % 2 == 0)
        {
            count++;
        }
        //Console.WriteLine(count);
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
}
//FillArray(8);
PrintArray(FillArray(4));
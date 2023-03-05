/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
int[] FillArray(int lenght, int minValue, int maxValue)
{
    int[] arr = new int[lenght];
    var rnd = new Random();
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
        if (i % 2 == 0)
        {
            sum += arr[i];
        }
    };
    Console.WriteLine($"сумма четных: {sum}");
    return arr;
};


int SearchMin(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[i + 1])
        {
            min = array[i+1];
        };
    };
    Console.WriteLine($"Минимальное: {min}");
    return min;
};

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(",", array) + "]");
};
PrintArray(FillArray(4, 1, 20));
int[] arr1 = {1,2,3,4,5};
SearchMin(arr1);


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на чётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
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
    Console.WriteLine();
    return arr;
};
void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(",", array) + "]");
};
PrintArray(FillArray(6, 100, 999));
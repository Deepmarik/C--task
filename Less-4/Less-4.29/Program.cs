/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
/*string a;
int[] b = new int[lenght];
int i = 0;

while ((a = Console.ReadLine()!) != "end") //Получаем строку и проверяем ее содержание
    b[i++] = Convert.ToInt32(a); //в стркое нет "конца" - значит конвертим и пишем в массив

for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
    Console.WriteLine(b[k]);

Console.ReadKey(true);*/

int[] CreateArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int lenght = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(lenght);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ",");
}
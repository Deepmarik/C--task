/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int max = 0;
if (a > b)
{
    max = a;
    Console.WriteLine(max);
}
else
{
    max = b;
    Console.WriteLine(max);
}

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Задача 4");
int aa = int.Parse(Console.ReadLine()!);
int bb = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max4;
max4 = aa;
if (max4 > bb && max4 > c)
{
     Console.WriteLine(max4); 
}
else
{
    max4 = bb;
    if (max4 > c)
    {
        Console.WriteLine(max4);
    }
    else
    {
        max4 = c;
        Console.WriteLine(max4);
    }}

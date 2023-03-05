/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            // Если m равно нулю
    else if (n == 0) return (m * (m + 1)) / 2;       // Если n равно нулю
    else if (m == n) return m;                       // Если m=n
    else if (m < n) return n + SumNumbers(m, n - 1); // Если m<n
    else return n + SumNumbers(m, n + 1);            // Если m>n
}
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Result, S = {SumNumbers(m, n)}");
Console.ReadLine();
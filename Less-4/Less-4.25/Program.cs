/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);
int DegreeNumber(int a, int b)
{
    int deegree = 1;
    for (int i = 1; i <= b; i++)
    {
        deegree *= a;
    }
    return deegree;
}
Console.WriteLine (DegreeNumber(numA, numB));
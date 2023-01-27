/*Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11*/
int num = int.Parse(Console.ReadLine()!);

/*double numSqrt = Math.Round(Math.Sqrt(num));
int i = 2;
for (int i = 2; i < num; i++)
{

    //double numSqrt = Math.Round(Math.Sqrt(i));
    //Console.WriteLine(numSqrt);

    for (int j = 2; j <= numSqrt; j++)
    {
        //double numSqrt = Math.Round(Math.Sqrt(i));
        if (j % numSqrt != 0)
        {

            Console.WriteLine(i + " " + "i");
        };
    };
};


/*while (i <= numSqrt)
{
    if (num % i == 0)
    {
        i++;
        Console.WriteLine(num);

    }
};
//Console.WriteLine(numSqrt);*/
/*int j = 0;
for (int i = 2; i < num; i++)
{
    if (num % i != 0)
    {
        j = j + 1;
        Console.WriteLine(num);
    }
}
//Console.WriteLine(num);*/
/*int flag = -1;
for (int i = 2; i <= num; i++)
{
    double numSqrt = Math.Round(Math.Sqrt(i));
    for (int j = 1; j < numSqrt; j++)
    {
        if (i % j == 0)
        {
            flag += flag;
        }
        else 
        {
            Console.WriteLine(i);
        }
    }
};*/
/*using System;
namespace Prime
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите конечное значение диапазона 1...N и нажмите Enter");
            Console.WriteLine("N = ");
            int num = int.Parse(Console.ReadLine()!);
            //if ((!int.TryParse(Console.ReadLine(), out int result)) || (result < 0))
               // Console.WriteLine("Число должно быть положительным и целым");
            Console.WriteLine($"Простые числа из диапазона от 1 до {num}");
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Найдено {count} простых чисел из диапазона от 1 до {num}");
        }
    }
}*/
bool IsPrime(int value)
{
    for (int i = 2; i < value; i++)
        if (value % i == 0)
            return false;
    return true;
}
/*bool IsPrime(int x)
{
    if (x < 2)
        return false;
    if (x % 2 == 0)
        return x == 2;

    int lim = (int)Math.Sqrt(x);
    for (int i = 3; i <= lim; i += 2)
    {
        if (x % i == 0)
            return false;
    };
    return true;
};*/

for (int i = 2; i < num; ++i)
{
    if (IsPrime(i))
        Console.Write("{0} ", i.ToString());
}
Console.WriteLine();

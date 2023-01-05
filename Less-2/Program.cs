/*Console.WriteLine("Задача 8");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
};*/
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Задача 10");
//string Num = Console.ReadLine()!;

int Num = int.Parse(Console.ReadLine()!);
string Digit = Convert.ToString(Num);
char [] arr = Digit.ToCharArray();
Console.WriteLine(arr[1]);



/*int ci = 12398;
string ac = ci.ToString();
int[] arrInt = new int[ac.Length];
for(int n = 0; n < ac.Length; ++n){ 
  arrInt[n] = int.Parse(ac[n]+ "");
  }*/


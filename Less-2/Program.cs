/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Задача 10 - первый вариант");
//string Num = Console.ReadLine()!;
// решение 
int Num = int.Parse(Console.ReadLine()!);
string Str = Convert.ToString(Num);
char[] arr = Str.ToCharArray();
Console.WriteLine(arr[1]);
Console.WriteLine();
//второй способ
Console.WriteLine("Задача 10- второй вариант\n");
int Digit = int.Parse(Console.ReadLine()!);
int Remainder = (Digit / 10) % 10;
Console.WriteLine(Remainder);



/*int ci = 12398;
string ac = ci.ToString();
int[] arrInt = new int[ac.Length];
for(int n = 0; n < ac.Length; ++n){ 
  arrInt[n] = int.Parse(ac[n]+ "");
  }*/


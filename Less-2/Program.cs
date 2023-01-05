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

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.WriteLine("Задача 13");
int Num13 = int.Parse(Console.ReadLine()!);
string Str13 = Convert.ToString(Num13);
char[] arr13 = Str13.ToCharArray();
Console.WriteLine();
int index = arr13.Length;
if (arr13.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else { Console.WriteLine(arr13[2]); }


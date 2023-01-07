/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
int palindrome = int.Parse(Console.ReadLine()!);
char[] palindromeArr = palindrome.ToString().ToCharArray();

if (palindrome >= 10000 && palindrome <= 99999)
{
    int length = palindromeArr.Length;
    //Console.WriteLine(Length);
    if (palindromeArr[0] == palindromeArr[length - 1] && palindromeArr[1] == palindromeArr[length - 2])
    {
        Console.WriteLine($"Палиндром -: {palindrome}");
    }
    else
    {
        Console.WriteLine($"Не палиндром -: {palindrome}");
    }
}
else{
    Console.WriteLine($"Число не удовлетворяет условию-: {palindrome}");
}

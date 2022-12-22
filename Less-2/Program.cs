//Less-2
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
int number = int.Parse(Console.ReadLine()!);
int GetLastDigit(int number){

    if (number < 100 || number > 999)
    {
        int LastDigit = number % 10;
        Console.WriteLine(LastDigit);
    }
};

GetLastDigit(number);
/*{
    Console.Write("Число не трехзначное");
}
else {
    Console.WriteLine($"Последня цифра числа {number} - {GetLastDigit(number)}");
}*/

/*string str = a.ToString();
int[] b = new int[str.Length];*/

/*for( int i=0; i< str.Length; i++)

{
     b[i] = int.Parse(str[i].ToString);
     Console.WriteLine(b);
}
*/

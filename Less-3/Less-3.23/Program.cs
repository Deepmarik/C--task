/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
/*int number = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= number; i++)
{
    double pow_num = Math.Pow(i, 3);
    Console.WriteLine(pow_num);
};*/
//
double NumThrePow(int digit)
{
    for (int i = 1; i <= digit; i++)
    {
        double pow_num = Math.Pow(i, 3);
        return pow_num;
        
    }
};
Console.WriteLine(NumThrePow(3));
/*Клим скажите пожалуйста, та часть закоменнтированная работает. Пытаюсь завренуть все это в метод, вылезает куча ошибок.
как их устранить, где ошибаюсь? */

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
string a;
int[] pointA = new int[3];
int i = 0;
Console.WriteLine("Введите координты A и нажмите пробел");
while ((a = Console.ReadLine()!) != " ") //Получаем строку и проверяем ее содержание
    pointA[i++] = Convert.ToInt32(a); //в строке нет " " - значит конвертим и пишем в массив

//координты точки B
Console.WriteLine("Введите координты B и нажмите пробел");
string b;
int[] pointB = new int[3];
i = 0;
while ((b = Console.ReadLine()!) != " ")
    pointB[i++] = Convert.ToInt32(b);
double distance = Math.Sqrt((pointA[0] - pointB[0]) * (pointA[0] - pointB[0]) + (pointA[1] - pointB[1]) * (pointA[1] - pointB[1]) + (pointA[2] - pointB[2]) * (pointA[2] - pointB[2]));
distance = Math.Round(distance, 2);
Console.WriteLine($"Расстояние между точками А и В  B -: {distance:f}");

//второй вариант
Console.WriteLine("Второй вариант");
var pointC = Console.ReadLine().Split().Select(int.Parse).ToArray();// получаю предупреждение warning CS8602- как избавиться?
var pointD = Console.ReadLine().Split().Select(int.Parse).ToArray();//получаю предупреждение warning CS8602- как избавиться?
double distanceTwo = Math.Sqrt((pointC[0] - pointD[0]) * (pointC[0] - pointD[0]) + (pointC[1] - pointD[1]) * (pointC[1] - pointD[1]) + (pointC[2] - pointD[2]) * (pointC[2] - pointD[2]));
Console.WriteLine($"Расстояние между А и B -: {distanceTwo:f}");
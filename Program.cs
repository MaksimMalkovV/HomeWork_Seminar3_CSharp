// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение точки А: ");
int numXA = int.Parse(Console.ReadLine()!);
int numYA = int.Parse(Console.ReadLine()!);
int numZA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки B: ");
int numXB = int.Parse(Console.ReadLine()!);
int numYB = int.Parse(Console.ReadLine()!);
int numZB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Подсчет результата ... ");
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double Res = Math.Sqrt(Math.Pow((numXB - numXA), (2)) + Math.Pow((numYB - numYA), (2)) + Math.Pow((numZB - numZA), (2)));

Console.WriteLine($"{Res:f2}");

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// 2 -> 1,4

Console.WriteLine("Введите значение: ");
int num = int.Parse(Console.ReadLine()!);
int i = 1;

while(i <= num)
{
    int res = Convert.ToInt32(Math.Pow(i,3));
    i++;
    Console.WriteLine($"{res}, ");
}

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число: ");
String M = Console.ReadLine()!;
int count = M.Length;
// 0 1 2 3 4
if (count == 5)
{
    int A = Convert.ToInt32(M[0]);
    int B = Convert.ToInt32(M[4]);
    int C = Convert.ToInt32(M[1]);
    int D = Convert.ToInt32(M[3]);
    if ((A == B) && (C == D))
    {
        Console.WriteLine($"Число {M} является полиномом !");
    }
    else
    {
        Console.WriteLine($"Число {M}  не полином !");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}
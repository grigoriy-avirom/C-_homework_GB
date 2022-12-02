/* 
Использовать методы. Без строкового типа
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/* 
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10000 && num < 100000)
{
    bool Palindrom()
    {
        int num1 = num % 10;
        int num2 = num % 100 / 10;
        int num3 = num % 1000 / 100;
        int num4 = num % 10000 / 1000;
        int num5 = num / 10000;
        return (num1 == num5 && num2 == num4);
    }
    Console.WriteLine(Palindrom() ? "Ваше число палиндром!" : "Ваше число не палиндром :(");
}
else
{
    Console.WriteLine("Число не пятизначное!");
}
 */


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/* 
Console.WriteLine("Введите координаты первой точки (x, y, z): ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x, y, z): ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double Dots(double x1, double y1, double z1, double x2, double y2, double z2) 
{
    double sum = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
    double dist = Math.Sqrt(sum);
    return dist;
}

double dist = Math.Round(Dots(x1, y1, z1, x2, y2, z2), 2); 
Console.WriteLine($"Расстояние между точками в 3D = {dist}");
 */


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 
*/

/* 
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Triple()
{
    int count = 1;
    while (count <= n)
    {
    Console.WriteLine($"Число {count} в кубе --> {Math.Pow(count, 3)}");
    count++;
    }
}
Triple(); 
*/
/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/* 
Console.WriteLine("Input quantity of elements: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] InputNums(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Input your {i + 1} element");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int CountNums(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = InputNums(quantity);
Console.WriteLine($"Quantity of positive elements is {CountNums(array)}");
 */




/* 
Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

/* 
Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double X(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}

double Y(double b1, double k1)
{
    double x = X(b1, k1, b2, k2);
    double y = k1 * x + b1;
    return x;
}

double x = X(b1, k1, b2, k2);
double y = Y(b1, k1);
x = Math.Round(x, 1);
y = Math.Round(y, 1);

if (k1 == k2)
    Console.WriteLine("Lines are parallel");
else
    Console.WriteLine($"Lines intersection point is ({x}; {y})");
 */

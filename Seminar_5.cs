/* 
Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

/* 
int[] CreateRandomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Random array: ");
int[] array = CreateRandomArray(6, 100, 999);
ShowArray(array);

int EvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int evenNumber = EvenNumber(array);
Console.WriteLine($"Quantity of even nums in array: {evenNumber}");
 */


/* 
Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

/* 
int[] CreateRandomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Random array: ");
int[] array = CreateRandomArray(5, -99, 99);
ShowArray(array);

int OddNums(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (i % 2 == 1)
    result += arr[i];
    }
    return result;
}

int oddNumber = OddNums(array);
Console.WriteLine($"Summ of odd nums in array: {oddNumber}");
 */


/* 
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

/* 
double[] CreateRandomDoubleArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    }
    return arr;
}

void ShowArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");

    }
    Console.WriteLine();
}

Console.Write("Random double array: ");
double[] array = CreateRandomDoubleArray(5, 0, 99);
ShowArray(array);

double Difference(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double MinDifference(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double differenceMax = Difference(array);
double differenceMin = MinDifference(array);
double result = differenceMax - differenceMin;

Console.Write($"Min and Max elements diff: {Math.Round(result, 2)}");
 */
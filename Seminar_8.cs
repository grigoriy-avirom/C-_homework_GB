/* 
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/* 
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortingRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int t = 0; t < matrix.GetLength(1) - 1; t++)
            {
                if (matrix[i, t] < matrix[i, t + 1])
                {
                    int temp = matrix[i, t + 1];
                    matrix[i, t + 1] = matrix[i, t];
                    matrix[i, t] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrix(5, 5, 0, 9);
Console.WriteLine("Unsorted matrix:");
ShowMatrix(matrix);

SortingRows(matrix);
Console.WriteLine("Sorted matrix:");
ShowMatrix(matrix);
*/


/* 
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/* 
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            // TODO: вывести индексы массива.
            // matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int RowSum(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int minsum = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            minsum += matrix[i, j];
        }
    }
    return minsum;
}

int MinRowSum(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int minsum = RowSum(matrix);
    int minElemRow = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            minElemRow = i;
        }
    }
    return minElemRow;
}

int[,] matrix1 = CreateMatrix(5, 5, 0, 9);
ShowMatrix(matrix1);

int minRowSum = MinRowSum(matrix1);
Console.WriteLine($"Row with minimal sum of elements is {minRowSum + 1} ");
*/


/* 
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/* 
int n = 5;
int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.Length)
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j],2} ");

            else Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Spiral matrix:");
Console.WriteLine();
ShowMatrix(matrix);
*/






/* 
Задача 58(дополнительно): Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


/* 
Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



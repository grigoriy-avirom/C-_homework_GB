/* 
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/* 
double[,] CreateDoubleMatrix(int rows, int colums, double min, double max)
{
    double[,] matrix = new double[rows, colums];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void ShowMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}; ");
        }
        Console.WriteLine();
    }
}

double[,] matrixArray = CreateDoubleMatrix(5, 5, 0, 9);
ShowMatrix(matrixArray);
*/


/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/* 
Console.WriteLine("Input row element number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column element number: ");
int column = Convert.ToInt32(Console.ReadLine());

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
}

void FindMatrixElement(int[,] matrix)
{
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
        Console.WriteLine($"Your element is {matrix[row, column]}");
    else
        Console.WriteLine($"There is no element [{row}, {column}] in matrix");
}

Console.WriteLine();
int[,] creatMatrixRndInt = CreateMatrix(5, 5, 0, 9);
ShowMatrix(creatMatrixRndInt);
Console.WriteLine();
FindMatrixElement(creatMatrixRndInt);
*/


/* 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
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

void Average(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double averageSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageSum += matrix[i, j];
        }
        double resultMathRound = Math.Round(averageSum / matrix.GetLength(0), 1);
        Console.WriteLine($"Average of column № {j} is {resultMathRound} ");
    }
}

Console.WriteLine();
int[,] creatMatrixRndInt = CreateMatrix(5, 5, 0, 9);
ShowMatrix(creatMatrixRndInt);
Average(creatMatrixRndInt);
*/

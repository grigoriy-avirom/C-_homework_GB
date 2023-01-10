/* 
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/* 
Console.Write("Input positive natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers(int n)
{
    if (n == 0 || n < 0) return;
    Console.Write(n + " ");
    NaturalNumbers(n - 1);
} 
*/


/* 
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/* 
Console.WriteLine("Input M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N");
int numN = Convert.ToInt32(Console.ReadLine());

int SumOfNums(int m, int n)
{
    if (m == n) return m;
    return SumOfNums(m + 1, n) + m;
}

int result = SumOfNums(numM, numN);
Console.WriteLine(result);
*/


/* 
Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную
*/

/*
Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());

void DecimToBinar(int n)
{
    if (n == 0) return;
    DecimToBinar(n / 2);
    if (n % 2 == 0) Console.Write(0);
    else Console.Write(1);
}

DecimToBinar(num);
*/
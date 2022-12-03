/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/* 
int MathPow(int num1, int num2)
{
    int result = 1;
    for (int count = 1; count <= num2; count++)
    {
        result = num1 * result;
    }
    return result;
}

Console.WriteLine("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = MathPow(numA, numB);
Console.WriteLine($"MathPow from {numA} to {numB} is {result}");
 */


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/* 
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SummOfDigits(int num)
{
    int summ = 0;
    while (num > 0)
    {
        summ = summ + num % 10;
        num = num / 10;
    }
    return summ;
}

if (number < 0)
{
    number = number * -1;
    int finalSumm = SummOfDigits(number);
    Console.WriteLine($"Summ of digits in -{number} is: -{finalSumm}");
}
else
{
    int finalSumm = SummOfDigits(number);
    Console.WriteLine($"Summ of digits in {number} is: {finalSumm}");
}
*/


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 
*/

/* 
int[] array = new int [8];

void NewRandomArray(int[] array)
{
    Random randomNum = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNum.Next(-999, 1000);
    }
}

void ShowRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
                Console.Write($"{array[i]}, ");
    }
}

NewRandomArray(array);

Console.WriteLine("Your 8-elements random array:");
ShowRandomArray(array);
 */
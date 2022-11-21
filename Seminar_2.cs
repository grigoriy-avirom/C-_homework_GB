/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
Console.WriteLine("Введите трёхзначное число.");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Число не трёхзначное!");
}
else
{
    number = (number % 100) / 10;
    Console.WriteLine($"Вторая цифра числа буддет {number}");
}
*/



/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Number3rd(int number)
{
    int count = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        count = number % 10;
    }
    return count;
}

if (Number3rd(number) == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра: {Number3rd(number)}");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*
Console.Write("Введите цифру дня недели, для проверки выходной ли он: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.Write("Да");
}
else if (day < 1 || day > 7)
{
    Console.Write("Такого дня недели нет");
}
else
{
    Console.Write("Нет");
}
*/
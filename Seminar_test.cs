/* 
void MetFindSum(int a) // НЕВОЗВРАТНЫЙ МЕТОД
{
    int summa = 0;
    for (int current = 1; current <= a; current++)
    {
        summa += current;
    }
    Console.WriteLine($" Summ of elements from 1 to {a} is {summa}");
}
Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
MetFindSum(user_num); 
*/
/* 
int MetFindSum(int a) // ВОЗВРАТНЫЙ МЕТОД
{
    int summa = 0;
    for (int current = 1; current <= a; current++)
    {
        summa += current;
    }
    return summa;
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int result = MetFindSum(user_num);

Console.WriteLine($"Summ of elements from 1 to {user_num} is {result}");
 */

/* 

int CountOfDigits(int number)
{
    int current = 1;
    while (number >= 10)
    {
        current++;
        number = number / 10;
    }
    return current;
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int count_digit;
int user_num1 = (-1) * user_num;
if (user_num >= 0)
    count_digit = CountOfDigits(user_num);
else
    count_digit = CountOfDigits(user_num1);

Console.WriteLine($"Entered num {user_num} -> {count_digit}");
 */

/* 
void Factorial(int n)
{
    int multi = 1;
    for (int cur = 1; cur <= n; cur++)
    {
        multi *= cur;
    }
    Console.WriteLine($"{n} -> {multi}");
}

Console.WriteLine("Input num: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    while (number <= 0)
    {
        Console.WriteLine("pls, input positive num");
        number = Convert.ToInt32(Console.ReadLine());
    }
}

Factorial(number);
 */

/* int[] CreateNewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1); // (min, max+1)
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input count of elements: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());

/* int[] array1 = CreateNewArray(count_of_elem);
ShowArray(array1); */
/*
ShowArray(CreateNewArray(count_of_elem, minValue, maxValue));

 */
/* 

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindSummPos(int[] array)
{
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sumPos += array[i];
    return sumPos;
}

int FindSumNeg(int[] array)
{
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i ++)
        if (array[i] < 0)
            sumNeg += array[i];
    return sumNeg;
}

int size_array = 12;
int minValue = -9;
int maxValue = 9;

int [] createdArray = CreateRandomArray(size_array, minValue, maxValue);

ShowArray(createdArray);
Console.WriteLine($"Summ of positive elements is {FindSummPos(createdArray)}");
int resaltNeg = FindSumNeg(createdArray);
Console.WriteLine($"Summ of negative elements is {resaltNeg}");
 */

/* 
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindMultiPar(int[] arrayCreated, int size2)
{
    int[] arrayMulti = new int[size2];
    for (int i = 0; i < arrayCreated.Length / 2; i++)
    {
        arrayMulti[i] = array[0] * arrayCreated[arrayCreated.Length - 1 - i];
    }
    return
}

Console.WriteLine("Input size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible val in array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val in array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int size2;
if (array_size % 2 == 0)
    size2 = array_size / 2;
else size2 = (array_size + 1) / 2;

 */
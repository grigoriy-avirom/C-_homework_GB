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

// РАЗВОРОТ МАССИВА

/* 
int[] CreateNewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowNewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] ReverseArray(int[] array)
{
    int k = array.Length;
    for (int i = 0; i < k / 2; i++)
    {
        int temp = array[i];
        array[i] = array[k - 1 - i];
        array[k - 1 - i] = temp;
    }
    return array;
}

Console.WriteLine("Input size of  array: ");
int count_of_elements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateNewArray(count_of_elements, minValue, maxValue);
ShowNewArray(newArray);

Console.WriteLine();

int[] reverseArray = ReverseArray(newArray);
ShowNewArray(reverseArray);

 */

// ФИББОНАЧЧИ
/* 
void Fibonachi(int count, int a, int b)
{
    int[] fibArray = new int[count];
    fibArray[0] = a;
    fibArray[1] = b;
    for (int i = 2; i < count; i++)
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
    
    ShowArray(fibArray);
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Input count of elements: ");
int count_of_elements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first element: ");
int first_element = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second element: ");
int second_element = Convert.ToInt32(Console.ReadLine());

Fibonachi(count_of_elements, first_element, second_element);
 */

// ТРЕУГОЛЬНИК, ТРИ ЧИСЛА
/* 
bool Triangle(int side1, int side2, int side3)
{
    if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        return true;
    else return false;
}

Console.WriteLine("Input first side: ");
int first_side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second side: ");
int second_side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third side: ");
int third_side = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(first_side, second_side, third_side);
if (result == true)
    Console.WriteLine("Triangle exist!");
else Console.WriteLine("Triangle not exist!");

 */

// ДЕСЯТИЧНОЕ В ДВОИЧНОЕ

/* 

string BinarSyst(int num)
{
    string binResult = string.Empty;
    while (num != 0)
    {
        binResult = num % 2 + binResult;
        num /= 2;
    }
    return binResult;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

string res = BinarSyst(number);
Console.WriteLine($"Your number {number} in binar syst is {res}");

 */



// ЗАДАЙТЕ ДВУМЕРНЫЙ МАССИВ m x n С ЦЕЛЫМИ ЧИСЛАМИ

/* 
int[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return created2dArray;
}

void Show2dArray(int[,] array)
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

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2dArray(rows, columns, min, max);
Console.WriteLine();
Show2dArray(newArray);
*/

// ЗАДАЙТЕ 2Д МАССИВ Amn = m+n

// ЗАДАЙТЕ 2Д МАССИВ, ЧЕТНЫЕ ЭЛЕМЕНТЫ ЗАМЕНИТЬ НА ИХ КВАДРАТЫ
// 0,2 0,4 2,2 2,4 ...

/* 

int[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return created2dArray;
}

void Show2dArray(int[,] array)
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

int[,] EvenNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}
int[,] created2dArray = Create2dArray(5, 6, -5, 10);

Show2dArray(created2dArray);
EvenNumbers(created2dArray);
Show2dArray(created2dArray);
*/


// НАЙДИТЕ СУММУ ЭЛЕМЕНТОВ ГЛАВНОЙ ДИАГОНАЛИ

/* 
int[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return created2dArray;
}

void Show2dArray(int[,] array)
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

int SumNumber(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

int[,] newArray = Create2dArray(3, 3, 0, 3);
Show2dArray(newArray);
int sum = SumNumber(newArray);
Console.Write($"{sum}");
 */



//ПОМЕНЯТЬ МЕСТАМИ ДВЕ СТРОКИ В ДВУМЕРНОМ МАССИВЕ
/* 
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
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

int[,] ChangeArrayRows(int[,] array1, int row1, int row2)
{
    if (row1 >= 0 && row1 < array1.GetLength(0) && row2 >= 0 && row2 < array1.GetLength(0) && row1 != row2)
    {

        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int temp = array1[row1, j];
            array1[row1, j] = array1[row2, j];
            array1[row2, j] = temp;
        }
    }
    else Console.WriteLine("Incorrect input!");
    return array1;
}

Console.Write("Input number of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of 1st row to remove: ");
int user_row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of 2nd row to remove: ");
int user_row2 = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = Create2dArray (user_rows, user_columns, user_minValue, user_maxValue);
ShowArray(createdArray);
ShowArray(ChangeArrayRows(createdArray, user_row1, user_row2));

 */


//ПРОГРАММА ЗАМЕНЯЮЩАЯ СТРОКИ НА СТОЛБЦЫ

/* 
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
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

void ChangeArray(int[,] array2)
{
    if (array2.GetLength(0) <= 0 || array2.GetLength(1) <= 0)
    {
        Console.WriteLine("It should be square matrix");
    }
    else
    {
        int[,] array3 = new int[array2.GetLength(1), array2.GetLength(0)];
        for (int i = 0; i < array2.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array3[j, i] = array2[i, j];
            }
    ShowArray(array3);
    }
}

Console.Write("Input number of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int [,] newMatrix = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
ShowArray(newMatrix);
ChangeArray(newMatrix);
 */


// ПРОГРАММА ОБНУЛЯЕТ СТРОККУ И СТОЛБЕЦ, 
// НА ПЕРЕСЕЧЕНИИ ПЕРВОГО НАИМЕНЬШЕГО ЭЛЕМЕНТА МАССИВА

/* 
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
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

int[] GetMinIndex(int[,] inArray)
{
    int iMin = 0;
    int jMin = 0;

    for (int i = 0; i < inArray.GetLength(0); i++)
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < inArray[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    return new[] { iMin, jMin };
}

void GetZero(int[,] arrayStart, int[] minInd)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
    {
        arrayStart[i, minInd[1]] = 0;
        for (int j = 0; j < arrayStart.GetLength(1); j++)
            arrayStart[minInd[0], j] = 0;
    }
    ShowArray(arrayStart);
}

Console.Write("Input number of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int [,] firstArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
ShowArray(firstArray);
int [] minIndexArray = GetMinIndex(firstArray);
GetZero(firstArray, minIndexArray);
*/




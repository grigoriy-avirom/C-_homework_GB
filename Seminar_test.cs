/*
int Digits(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int result;
    if (ed > dec)
    {
        return ed;
    }
    else return dec;

}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int res = Digits(user_num);

Console.WriteLine($"Biggest digit: {res}");
*/
/*
int Digits()
{
    int randomNum = new Random().Next(10, 100);
    Console.WriteLine("Your num: " + randomNum);

    int ed = randomNum % 10;
    int dec = randomNum / 10;

    if (ed > dec)
    {
        return ed;
    }
    else return dec;

}
 Console.WriteLine("Biggest num: " + Digits());
 */

/*
void Cratnost(int num, int a, int b)
{
    if (num % a == 0 && num % b == 0)
    {
        Console.WriteLine($"Your num {num} is multiple {a} and {b}");
    }
    else Console.WriteLine($"Your num {num} is not multiple {a} and {b}");
}

Console.WriteLine("Enter num: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 1st div: ");
int div1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd div: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Cratnost(user_num, div1, div2);
*/

int DeleteDec()
{
    int randomNum = new Random().Next(100, 1000);
    Console.WriteLine("Your num is: " + randomNum);

    int fut_dec = randomNum / 100;
    int fut_ed = randomNum % 10;

    int new_num = fut_dec * 10 + fut_ed;
    return new_num;
}

Console.WriteLine($"Your new num is: {DeleteDec()}");

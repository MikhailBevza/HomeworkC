// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Вариант 1

/*
bool Palindrome(int number)
{
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num4 = number / 10 % 10;
    int num5 = number % 10;

    if(num1 == num5 && num2 == num4) return true;
    else return false;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num *= -1;

if(num > 10000 && num < 100000)
{
    if(Palindrome(num)) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}
else Console.WriteLine("Число не является пятизначным");
*/

// Вариант 2

/*
bool Palindrome(int number)
{
    int tempVar = number;
    int reverse = 0;
    while(number != 0)
    {
        int lastDigit = number % 10;
        number /= 10;
        reverse = reverse * 10 + lastDigit;
    }

    if(tempVar == reverse) return true;
    else return false;

}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(Palindrome(num)) Console.WriteLine("Число является палиндромом.");
else Console.WriteLine("Число не является палиндромом.");
*/


// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Length( double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Length(x1, y1, z1, x2, y2, z2));
*/


// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void CubeNumber(int number)
{
    int num = 1;
    while(num <= number)
    {
        Console.Write(Math.Pow(num, 3) + " ");
        num++;
    }
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

CubeNumber(num1);
*/
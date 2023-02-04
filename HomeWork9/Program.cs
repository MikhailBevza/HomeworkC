// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void NaturalNumbers(int num)
{
    Console.Write($"{num} ");
    if(num > 1) NaturalNumbers(num - 1);
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int num1, int num2)
{
    if(num1 > num2) return num1 + SumNumbers(num1 - 1, num2);
    if(num1 < num2) return num1 + SumNumbers(num1 + 1, num2);
    else return num1;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumNums = SumNumbers(m, n);
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N равна: " + sumNums);
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int m, int n)
{
    if(m == 0) 
        return n + 1;
    else 
        if(m != 0 && n == 0)
            return AckermanFunction(m - 1, 1);
        else 
            return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AckermanFunction(m, n));

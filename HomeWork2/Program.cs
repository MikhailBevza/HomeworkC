// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondNumber(int number)
{
    int secondNum = number / 10 % 10;
    return secondNum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0)
    num *= -1;

if(num > 99 && num < 1000) 
    Console.WriteLine($"Вторая цифра этого числа: {SecondNumber(num)}");
else
    Console.WriteLine("Число не является трёхзначным.");
*/


// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdDigit(int number)
{
    while(number > 1000)
    {
        number /= 10;
    }
    int thirdNum = number % 10;
    return thirdNum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0)
    num *= -1;

if(num > 100)
    Console.WriteLine($"Третья цифра числа: {ThirdDigit(num)}");
else
    Console.WriteLine("Третьей цифры нет.");
*/


// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool WeekDay(int number)
{
    if(number == 6 || number == 7)
        return true;
    else
        return false;
}

Console.WriteLine("Программа демонстрирует является ли день недели (обозначается цифрой) выходным днем");
Console.Write("Введите цифру: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day >= 1 && day <= 7)
{
    if(WeekDay(day))
        Console.WriteLine("Является выходным днем");
    else
        Console.WriteLine("Не является выходным днем");
}
else 
{
    Console.WriteLine("Такого дня недели не существует");
}
*/

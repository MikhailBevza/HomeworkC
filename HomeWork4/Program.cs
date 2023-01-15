// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponentiation(int num1, int num2)
{
    int res = 1;
    for(int i = 1; i <= num2; i++)
        res *= num1;

    return res;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(a, b);
Console.WriteLine(result);
*/


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumOfDigits(int number)
{
    int sum = 0;
    while(number != 0)
    {
        int temp = number % 10;
        sum += temp;
        number /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num *= -1;

int result = SumOfDigits(num);
Console.WriteLine(result);
*/


// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент мвссива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;   
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write($"[{array[i]}, ");
        else if(i == array.Length - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] arrNums = CreateArray(length);

PrintArray(arrNums);
*/


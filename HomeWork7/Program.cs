// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandomDouble2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    
    return array;
}

void ShowDouble2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
    
        Console.WriteLine();
    } 
    Console.WriteLine();
}

double[,] newArray = CreateRandomDouble2dArray();
ShowDouble2dArray(newArray);
*/


//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
    
        Console.WriteLine();
    } 
    Console.WriteLine();
}


void ElementFromArray(int[,] array)
{
    Console.Write("Введите индекс строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите индекс столбца: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    if(rows < array.GetLength(0) && columns < array.GetLength(1))
        Console.WriteLine($"Значение элемента массива на данной позиции: {array[rows, columns]}");
    else Console.WriteLine("Элемента с такими индексами в массиве нет.");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

ElementFromArray(newArray);



//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
    
        Console.WriteLine();
    } 
    Console.WriteLine();
}

double[] ArithmeticMean(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            newArray[i] += array[j, i];
            if(j == array.GetLength(0) - 1)
                newArray[i] /= array.GetLength(0);
        }
    }
    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

double[] arithmeticMeanArray = ArithmeticMean(newArray);
ShowArray(arithmeticMeanArray);
*/
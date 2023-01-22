/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}
*/

//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int NumberOfEvenElements(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;

    return count;
}
*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumOfElements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];

    return sum;
}
*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

double DiffMinMax(double[] array)
{
    double minElement = array[0];
    double maxElement = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minElement) minElement = array[i];
        else if(array[i] > maxElement) maxElement = array[i];
    }
    double diff = maxElement - minElement;
    return diff;
}

Console.Write("input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomDoubleArray(length, min, max);
ShowArray(newArray);

double diff = DiffMinMax(newArray);
Console.WriteLine("Difference between the maximum and minimum array elements: " + diff);

// Первая задача.
/*
int quantity = NumberOfEvenElements(newArray);
Console.WriteLine("The number of even elements in the array: " + quantity);
*/

// Вторая задача.
/*
int sum = SumOfElements(newArray);
Console.WriteLine("The sum of the elements standing in odd positions: " + sum);
*/


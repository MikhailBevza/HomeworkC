// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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


int[,] Sort2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
            {
                if(array[i, k] < array[i, k + 1])
                {
                int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int[,] sortArray = Sort2dArray(newArray);
Show2dArray(sortArray);
*/


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int MinSumElements(int[,] array)
{
    int minSumElementsInRows = 0;

    for (int i = 0; i < array.GetLength(1); i++)
        minSumElementsInRows += array[0, i];

    int curSumElementsInRows = 0;
    int numberRows = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            curSumElementsInRows += array[i, j];
        
        if(curSumElementsInRows < minSumElementsInRows)
        {
            minSumElementsInRows = curSumElementsInRows;
            numberRows++;
        }
        curSumElementsInRows = 0;
    }
    return numberRows;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int numberMinRows = MinSumElements(newArray);
Console.WriteLine($"Наименьшая сумма элементов в {numberMinRows} строке.");
*/


// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] GeneratoroNonRepeatingIntegers(int[,,] array)
{
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int count = 0;

    while(count < tempArray.GetLength(0))
    {
        int randomNums = new Random().Next(10, 100);
        bool status = true;

        for (int i = 0; i < count; i++)
        {
            if(randomNums == tempArray[i])
            {
                status = false;
                break;
            }
        }
        if(status)
        {
            tempArray[count] = randomNums;
            count++;
        }
    }
    return tempArray;
}

int[,,] Create3dArray(int plane, int rows, int columns)
{
    int[,,] array = new int[plane, rows, columns];

    int[] newTempArray = GeneratoroNonRepeatingIntegers(array);
    int count = 0;

    for (int i = 0; i < plane; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                array[i, j, k] = newTempArray[count];
                count++;
            }
        }
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    } 
    Console.WriteLine();
}

Console.Write("Введите количество слоёв: ");
int plane = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

if(plane * rows * columns <= 90)
{
    int[,,] newArray = Create3dArray(plane, rows, columns);
    Show3dArray(newArray);
}
else 
    Console.WriteLine("Слишком много элементов.");



// Напишите программу, которая заполнит спирально массив N на M.

/*
int[,] Spiral2dArrays(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int iMin = 0, iMax = 0, jMin = 0, jMax = 0;
    
    int i = 0, j = 0;

    for (int count = 1; count <= rows * columns; count++)
    {
        array[i, j] = count;

        if(i == iMin && j < columns - 1 - jMax)
            j++;
        else if(j == columns - 1 - jMax && i < rows - 1 - iMax)
            i++;
        else if(i == rows - 1 - iMax && j > jMin)
            j--;
        else 
            i--;

        if(i == iMax + 1 && j == jMin)
        {
            iMin++;
            iMax++;
            jMin++;
            jMax++;
        }

    }
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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Spiral2dArrays(rows, columns);
Show2dArray(newArray);
*/


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] DivArrays(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i,j] = 0;

            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i,j] += array1[i,k] * array2[k,j];
            }
        }
    }
    return array3;
}

int[,] newArray1 = CreateRandom2dArray();
Console.WriteLine();
int[,] newArray2 = CreateRandom2dArray();

Show2dArray(newArray1);
Console.WriteLine();
Show2dArray(newArray2);
Console.WriteLine();

if(newArray1.GetLength(1) == newArray2.GetLength(0))
{
    int[,] multiplicationOfNumbers = DivArrays(newArray1, newArray2);
    Show2dArray(multiplicationOfNumbers);
} else
    Console.WriteLine("Произведение матриц невозможно.");
*/
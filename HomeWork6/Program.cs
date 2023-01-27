// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int QuantityNumbers(int quantity)
{
    int count = 0;
    for(int i = 0; i < quantity; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int quantityNums = QuantityNumbers(quantity);
Console.WriteLine("Количество чисел больше 0: " + quantityNums);
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] IntersectionOfStraightLines(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    double[] array = new double[2];
    array[0] = x;
    array[1] = y;

    return array;
}

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] intersectionPoint = IntersectionOfStraightLines(k1, b1, k2, b2);

if(k1 != k2 && b1 != b2) Console.WriteLine($"Прямые пересекаются в точке: ({intersectionPoint[0]}; {intersectionPoint[1]})");
else if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
else Console.WriteLine("Прямые не пересекаются.");
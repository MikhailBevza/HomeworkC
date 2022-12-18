// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first namber: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) Console.Write("max = " + a + ", min = " + b);
if(b > a) Console.Write("max = " + b + ", min = " + a);
if(a == b) Console.Write("The numbers are equal");
*/


// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = " + max);
*/


// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0) Console.Write("Yes");
else Console.Write("No");
*/


// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 2;

if(n > 1)
{
    while(count <= n)
    {
        if(count >= n-1) Console.Write(count);
        else Console.Write(count + ", ");
        count += 2;
    }
}
else Console.Write("The number must be greater than 1");
*/


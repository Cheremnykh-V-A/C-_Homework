// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberA < min) min = numberA;
if (numberB < min) min = numberB;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);


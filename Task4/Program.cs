// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int max = a1;
if (a2 > max) max = a2;
if (a3 > max) max = a3;
Console.WriteLine("Максимальное из 3-х чисел = " + max);
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b) Console.WriteLine("первое число: " + a + " больше втрого: " + b);
else Console.WriteLine("первое число: " + a + " меньше втрого: " + b);

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999) Console.WriteLine("Число не трехзначное");
else Console.WriteLine("Вторая цифра числа: " + (num / 10) % 10);

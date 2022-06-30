// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// решение с привязкой до десяти тысячных чисел
// else if (num < 1000) Console.WriteLine("Третья цифра числа: " + num % 10);
// else if (num < 10000) Console.WriteLine("Третья цифра числа: " + (num / 10) % 10);
// else Console.WriteLine("Третья цифра"); 

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int a = 1000;
int b = 1;
int x = 2; // служебная переменная для цикла

while (x > 1)
{
    if (num <= 99) { Console.WriteLine("Третьей цифры нет"); break; }
    else if (num < a) { Console.WriteLine("Третья цифра числа: " + (num / b) % 10); break; }
    else a = a * 10; b = b * 10; x++;
}

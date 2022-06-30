// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// число с 1 по 5 - рабочие дни 
// число 6,7 - выходные дни


Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7) Console.WriteLine("Нет такого дня недели");
else if (day == 6 || day == 7 ) Console.WriteLine("Выходной день");
else Console.WriteLine("Рабочий день");
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 6)
    Console.WriteLine("Этот день недели не является выходным");
if (number == 6)
    Console.WriteLine("Этот день недели является выходным");
if (number == 7)
    Console.WriteLine("Этот день недели является выходным");
if (number > 7)
    Console.WriteLine("Такого дня недели нет");
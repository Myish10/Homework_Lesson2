// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int DigitNumber(int num)
{
    num = (num / 10) % 10;
    return num;
}

int num1 = DigitNumber(number);
Console.WriteLine($"Вторая цифра числа {number} -> {num1}");
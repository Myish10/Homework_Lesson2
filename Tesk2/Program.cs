//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

int DigitNumber(int num)
{
    int index = 1;
    int ind = 0;
    while (num > 1)
    {
        num = num / 10;
        index = index * 10;

    }
    ind = index / 1000;
    return ind;
}

if (number / 100 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int digitnum = DigitNumber(number);
    number = number / digitnum;
    Console.WriteLine(number % 10);
}

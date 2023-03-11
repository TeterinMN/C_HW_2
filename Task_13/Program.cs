Console.Clear();
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);

if (num > 999)
{
    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}
else if (num < 99)
    Console.WriteLine("Третьей цифры нет ");
else
    Console.WriteLine(num % 10);
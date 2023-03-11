Console.Clear();
Console.Write("Введите номер дня недели или 0 для выхода из программы: ");
int day = int.Parse(Console.ReadLine()!);
while (true)
{
    if (day == 1)
        Console.WriteLine($"{1} день это Понедельник");
    else if (day == 2)
        Console.WriteLine($"{2} день это Вторник");
    else if (day == 3)
        Console.WriteLine($"{3} день это Среда");
    else if (day == 4)
        Console.WriteLine($"{4} день это Четверг");
    else if (day == 5)
        Console.WriteLine($"{5} день это Пятница");
    else if (day == 6)
        Console.WriteLine($"{6} день это Суббота - ВЫХОДНОЙ");
    else if (day == 7)
        Console.WriteLine($"{7} день это Воскресенье - ВЫХОДНОЙ");
    else
        Console.WriteLine("Неверно введено число дня недели");
    Console.Write("Введите номер дня недели или 0 для выхода из программы: ");
    day = int.Parse(Console.ReadLine()!);
    if (day == 0)
        return;
}
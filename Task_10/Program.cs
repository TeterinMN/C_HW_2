Console.Clear();
Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine()!);

int result = (num / 10) % 10;
Console.WriteLine(result);
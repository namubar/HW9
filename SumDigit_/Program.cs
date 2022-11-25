Console.WriteLine("Введите первое число:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
int result = 0;
void SumDigit(int m, int n)
{
    if (m > n) return;
    result += m;
    SumDigit(m + 1, n);
}
SumDigit(m, n);
Console.Write($"Сумма элементов между {m} и {n} равна {result}");

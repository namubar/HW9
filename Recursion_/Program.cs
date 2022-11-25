Console.WriteLine("Введите натуральное число:");
int number = int.Parse(Console.ReadLine()!);
if (number < 1)
{
    Console.Write($" {number} не натуральное число");
}
else
{
    void Result(int number)
    {
        if (number <1) return;
        Console.Write("  " + number);
        Result(number - 1);
    }
    Result(number);
}
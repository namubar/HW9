Console.Write("Введите первое число: ");                    //          n+1;                m=0;
int m = int.Parse(Console.ReadLine ()!);                    //A(m,n)=   A(m-1,1)            m>0; n=0;
Console.Write("Введите второе число: ");                    //          A(m-1, A(m, n-1))   m>0; n>0;
int n = int.Parse(Console.ReadLine ()!);
Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
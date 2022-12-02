Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Cумма натуральных элементов в промежутке: " ); 
    Console.Write(SumMN(m - 1, n));
    Console.ResetColor();
}
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

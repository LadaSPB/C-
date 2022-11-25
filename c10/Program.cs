Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
int exponentiation = Exponentiation(numA, numB);
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"{numA} в степени {numB} = {exponentiation}");
Console.ResetColor();
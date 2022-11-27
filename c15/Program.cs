int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Минимальное число: {min}");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Минимальное число: {max}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");
Console.ResetColor();

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);


int[] GetCubeTable(int N)
{
    int[] cubs = new int[N + 1];
    for (int i = 1; i < cubs.Length; i++)
    {
        cubs[i] = i * i * i;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{i} ^ 3 = ");
        Console.WriteLine(array[i]);
    }
}

int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);
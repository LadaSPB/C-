
// 26 задача 
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0; //количество цифр в числе

// while (A > 0)
// {
//     A /= 10; // A = A/10
//     count++;
// }
// int getNumberFromUser(string message)
// {
//     int result = 0;
//     Console.ForegroundColor = ConsoleColor.DarkGreen;
//     Console.WriteLine(message);
//     Console.ResetColor();
//     result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// Console.WriteLine($"Количество цифр в числе = {count}");

// 28 задача 
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 1;

// for (int i = 1; i <= A; i++)
// {
//     Console.WriteLine($"i = {i}");
//     sum = sum * i;
// }
// Console.WriteLine($"Результат выполнения программы = {sum}");

// 30 задача 

// int n = 8;
// int[] arr = new int[n];
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0,2);
// }


// Console.WriteLine(string.Join(", ", arr));




// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SumOfRange (int start, int finish)
// {
//     int sum = 0;
//     for (int i = start; i < finish; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int getNumberFromUser(string message)
// {
//     int result = 0;
//     Console.ForegroundColor = ConsoleColor.DarkGreen;// цвет текста
//     Console.WriteLine(message);
//     Console.ResetColor();
//     result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int userNumber = getNumberFromUser("Введите А для подсчета суммы 1..А");
// int sum = SumOfRange(1, userNumber);
// Console.WriteLine($"Сумма чисел от 1 .. {userNumber} = {sum}");

// Туяна, [24.11.2022 20:57]
// // Задача 26: Напишите программу, которая принимает на 
// // вход число и выдаёт количество цифр в числе.
// // 456 -> 3
// // 78 -> 2
// // 89126 -> 5

// int getNumberOfDigits(int number)
// {
//     int numberOfDigit = 0;
//     while (number > 0)
//     {
//        number /= 10;
//        numberOfDigit++;
//        Console.WriteLine(number);
//     }
//     return numberOfDigit;
// }

// int getNumberFromUser(string message)
// {
//     int result = 0;
//     Console.ForegroundColor = ConsoleColor.DarkGreen;// цвет текста
//     Console.WriteLine(message);
//     Console.ResetColor();
//     result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int userNumber = getNumberFromUser("Введите число: ");
// int numberOfDigit = getNumberOfDigits(userNumber);
// Console.ForegroundColor = ConsoleColor.DarkMagenta;
// Console.WriteLine($"Количество цифр в числе {userNumber} = {numberOfDigit}");
//  Console.ResetColor();


/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение  
чисел от 1 до N. 
4 -> 24  
5 -> 120 
*/ 
 
// int multOfRange (int start, int finish) 
// { 
//     int mult = 1; 
//     for (int i = start; i <= finish; i++) 
//     { 
//         mult *= i; 
//     } 
//     return mult; 
// } 
 
// int getNumberFromUser(string message) 
// { 
//     int result = 0; 
//     Console.ForegroundColor = ConsoleColor.DarkGreen;// цвет текста 
//     Console.WriteLine(message); 
//     Console.ResetColor(); 
//     result = Convert.ToInt32(Console.ReadLine()); 
//     return result; 
// } 
 
// int userNumber = getNumberFromUser("Введите N для подсчета произведения 1..N"); 
// int mult = multOfRange(1, userNumber); 
// Console.WriteLine($"Произведения чисел от 1 до  {userNumber} = {mult}");

30 задача2вар

int [] getRange( int length)
{
    int [] array = new int [length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(0, 2);
    }
    return array;
}

void printArray( int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int [] array = getRange(8);
printArray(array);
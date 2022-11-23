Console.WriteLine("Введите пятизначное число:");
string writeTxt = Console.ReadLine();
string txtToCheck = writeTxt.ToLower().Replace(" ","");
int length = txtToCheck.Length;
string result = "не является";

bool IsPalindrome(string p)
{
    int count = 0;
    while (count <= length)
    {
        if (txtToCheck[count] != txtToCheck[length - 1]) return false;
        length--;
        count++;
    }
    return true;
}

if (IsPalindrome(txtToCheck)) result = "является";
Console.WriteLine($"Введенное значение {result} палиндромом");
Console.WriteLine();
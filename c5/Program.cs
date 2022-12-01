Console.Write("Введите число: ");
int AnyNumero = Convert.ToInt32(Console.ReadLine());
string AnyNumeroText = Convert.ToString(AnyNumero);
if (AnyNumeroText.Length > 2)
{
Console.WriteLine("Третья цифра: " + AnyNumeroText[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}

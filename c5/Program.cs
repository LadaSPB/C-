Console.Write("Введите число: ");
int AnyNumero = Convert.ToInt32(Console.ReadLine());
string anyNumeroText = Convert.ToString(AnyNumero);
if (anyNumeroText.Length > 2)
{
Console.WriteLine("Третья цифра: " + anyNumeroText[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}

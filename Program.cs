Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= n | n <= 1)
{
  Console.WriteLine("Натуральных чисел от M до N не существует! ");
  return;
}
/// <summary>
/// Метод, который печатает все натуральные числа в промежутке
/// </summary>
/// <param name="start">Цифра от которой идет перечесление</param>
/// <param name="end">Цифра до которой идет перечисление</param>
/// <returns></returns>
string PrintNumbers (int start, int end)
{
  if (start <= 0)
  {
    start = 1;
  }
  if (start == end) return start.ToString();
  return (start + "," + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(m, n));
// All natural numbers in the range from N to 1. Execute using recursion.
Console.WriteLine ("Task conditions: N = 5 -> 5, 4, 3, 2, 1 and N = 8 -> 8, 7, 6, 5, 4, 3, 2, 1");
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)},");
  return m;
}
Console.WriteLine ("Еnter only natural numbers");
int n = Prompt("N: ");
Console.WriteLine(NaturalNumber(n, 1));
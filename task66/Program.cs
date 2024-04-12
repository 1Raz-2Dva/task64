// Set the values ​​of M and N. Write a program that will find the sum of natural elements in the interval from M to N. Execute using recursion.
Console.WriteLine ("Task conditions: M = 1; N = 15 -> 120 M = 4; N = 8 -> 30");
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int SumOfElements(int n, int m)
{
  if (n == m) return n;
  else return SumOfElements(n - 1, m) + n;
}
Console.WriteLine ("Еnter only natural numbers");
int n = Prompt("N: ");
int m = Prompt("M: ");
Console.WriteLine(SumOfElements(n, m));
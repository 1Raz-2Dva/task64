// Write a program to evaluate the Ackermann function using recursion. Given two non-negative numbers m and n.
Console.WriteLine ("Task conditions: m = 2, n = 3 -> A(m,n) = 9; m = 3, n = 2 -> A(m,n) = 29");
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine ("Еnter non-negative integer (Natural) numbers");
int m = Prompt("M: ");
int n = Prompt("N: ");
Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
namespace _30_Days_of_Code
{
  using System;

  /// <summary>
  /// The AdvancedArithmetic interface
  /// </summary>
  public interface AdvancedArithmetic
  {
    int divisorSum(int n);
  }

  partial class Calculator : AdvancedArithmetic
  {
    public int divisorSum(int n)
    {
      int sum = 0;
      for (int i = n; i > 0; i--)
      {
        if (n % i == 0)
        {
          sum = sum + i;
        }
      }

      return sum;
    }
  }

  /// <summary>
  /// The solution.
  /// </summary>
  public partial class Solution
  {
    static void Main19(string[] args)
    {
      int n = Int32.Parse(Console.ReadLine());
      AdvancedArithmetic myCalculator = new Calculator();
      int sum = myCalculator.divisorSum(n);
      Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
  }
}

namespace Cracking_The_Coding_Interview._03_TechniquesConcepts
{
  using System;

  internal class RecursionFibonacciNumbers {
    
    public static int Fibonacci(int n)
    {
      return n != 0 && n != 1 ? Fibonacci(n - 1) + Fibonacci(n - 2) : n;
    }

    static void Main(String[] args) {
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(Fibonacci(n));
    }
  }
}

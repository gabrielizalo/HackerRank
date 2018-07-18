using System;

// ReSharper disable once CheckNamespace
// ReSharper disable once ArrangeTypeModifiers
class EvenFibonacciNumbers
{
  public static void EvenFibonacciNumbersMain(string[] args)
  {
    var t = Convert.ToInt32(Console.ReadLine());
    for (var a0 = 0; a0 < t; a0++)
    {
      var n = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine(SumEvenFibonacciNumbers(n));
    }

    Console.ReadLine();
  }

  private static long SumEvenFibonacciNumbers(long l)
  {
    long sumEven   = 0;
    long number1   = 0;
    long fibonacci = 1;

    while (fibonacci < l)
    {
      var temp = number1;
      number1   = fibonacci;
      fibonacci = temp + fibonacci;

      if (fibonacci % 2 == 0 && fibonacci < l)
      {
        sumEven += fibonacci;
      }
    }

    return sumEven;
  }
}

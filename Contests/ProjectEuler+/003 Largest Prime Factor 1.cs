using System;

// HACKER RANK > FAILED CASE 5
// ---------------------------

// ReSharper disable once CheckNamespace
// ReSharper disable once ArrangeTypeModifiers
class LargestPrimeFactor1
{
  public static void LargestPrimeFactor1Main(string[] args)
  {
    var t = Convert.ToInt32(Console.ReadLine());
    for (var a0 = 0; a0 < t; a0++)
    {
      var n = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine(GetLargestPrimeFactor(n));
    }

    Console.ReadLine();
  }

  private static long GetLargestPrimeFactor(long theNumber)
  {
    long largestPrimeFactor = 0;

    if (theNumber % 2 == 0)
    {
      largestPrimeFactor = 2;
    }

    long i = 3;
    while (i <= theNumber)
    {
      if (theNumber % i == 0 && IsPrime(i))
      {
        largestPrimeFactor = i;
      }

      i = i + 2;
    }

    return largestPrimeFactor;
  }

  private static bool IsPrime(long number)
  {
    if (IsFirstPrime(number))
    {
      return true;
    }

    if (IsDivisibleByFirstPrimes(number))
    {
      return false;
    }

    var  isPrime   = true;
    long oddNumber = 29;
    while (isPrime && number > oddNumber)
    {
      if (number % oddNumber == 0)
      {
        isPrime = false;
      }

      oddNumber = GetNextMaybePrime(oddNumber);
    }

    return isPrime;
  }

  private static bool IsFirstPrime(long number)
  {
    return number == 2
        || number == 3  || number == 5  || number == 7  || number == 11
        || number == 13 || number == 17 || number == 19 || number == 23;
  }

  private static bool IsDivisibleByFirstPrimes(long number)
  {
    return number % 2  == 0
        || number % 3  == 0 || number % 5  == 0 || number % 7  == 0 || number % 11 == 0
        || number % 13 == 0 || number % 17 == 0 || number % 19 == 0 || number % 23 == 0;
  }

  private static long GetNextMaybePrime(long oddNumber)
  {
    do
    {
      oddNumber = oddNumber + 2;
    } while (IsDivisibleByFirstPrimes(oddNumber));

    return oddNumber;
  }
}

using System;

// HACKER RANK > FAILED CASE 5
// ---------------------------

// ReSharper disable once CheckNamespace
// ReSharper disable once ArrangeTypeModifiers
class LargestPrimeFactor4
{
  public static void LargestPrimeFactor4Main(string[] args)
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
    // The number itself is prime
    if (theNumber > 2 && IsPrime(theNumber))
    {
      return theNumber;
    }

    // Verify other primer numbers
    long largestPrimeFactor = 0;

    if (theNumber % 2 == 0)
    {
      largestPrimeFactor = 2;
    }

    long i     = 3;
    var  limit = theNumber % 2 == 0 ? theNumber / 2 : (theNumber + 1) / 2;
    while (i <= limit)
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
    while (isPrime && number+1/2 > oddNumber)
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

using System;

// HACKER RANK > FAILED CASE 4 & 5
// -------------------------------

// ReSharper disable once CheckNamespace
// ReSharper disable once ArrangeTypeModifiers
class LargestPrimeFactor2
{
  public static void LargestPrimeFactor2Main(string[] args)
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
    var largestPrimeFactor = theNumber + 1;

    // Is the same number Max
    if (theNumber % 2 == 1 && IsPrime(theNumber))
    {
      return theNumber;
    }

    // Others from max to min
    var i = theNumber % 2 == 0 ? theNumber / 2: (theNumber + 1) / 2;
    if (i % 2 == 0)
    {
      i--;
    }
    while (largestPrimeFactor > theNumber && i > 1)
    {
      if (theNumber % i != 0 || !IsPrime(i))
      {
        i = GetPreviousMaybePrime(i);
        continue;
      }

      largestPrimeFactor = i;
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

  private static long GetPreviousMaybePrime(long oddNumber)
  {    
    do
    {
      oddNumber = oddNumber - 2;
      if (oddNumber == 1)
      {
        oddNumber = 2;
      }
    } while (!IsFirstPrime(oddNumber) && IsDivisibleByFirstPrimes(oddNumber) && oddNumber > 1);

    return oddNumber;
  }
}

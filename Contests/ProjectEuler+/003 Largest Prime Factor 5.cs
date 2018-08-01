using System;

// HACKER RANK > FAILED CASE 5
// ---------------------------

// ReSharper disable once CheckNamespace
// ReSharper disable once ArrangeTypeModifiers
class LargestPrimeFactor5
{
  public static void Main(string[] args)
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
    // Taken from https://stackoverflow.com/questions/17579091/faster-way-to-check-if-a-number-is-a-prime
    if (number     < 2) return false;
    if (number % 2 == 0) return (number == 2);
    long root = (int) Math.Sqrt((double) number);
    for (long i = 3; i <= root; i += 2)
    {
      if (number % i == 0) return false;
    }

    return true;
  }
}

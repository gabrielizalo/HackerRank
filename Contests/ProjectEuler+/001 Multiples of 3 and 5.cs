using System;

// ReSharper disable once ArrangeTypeModifiers
// ReSharper disable once CheckNamespace
class Solution
{
  static void Main(String[] args)
  {
    int t = Convert.ToInt32(Console.ReadLine());
    for (int a0 = 0; a0 < t; a0++)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(GetSumMultiples3Or5(n));
    }
  }

  private static ulong GetSumMultiples3Or5(int oldN)
  {
    var n    = Convert.ToUInt64(oldN);
    var of3  = (n - 1) / 3;
    var of5  = (n - 1) / 5;
    var of15 = (n - 1) / 15;

    return 3 * of3 * (of3 + 1) / 2
         + 5 * of5 * (of5 + 1) / 2
         - 15 * of15 * (of15 + 1) / 2;
  }

  private static int GetSumMultiples3Or5Old4(int n)
  {
    var of3  = (n - 1) / 3;
    var of5  = (n - 1) / 5;
    var of15 = (n - 1) / 15;

    return 3 * of3 * (of3 + 1) / 2
         + 5 * of5 * (of5 + 1) / 2
         - 15 * of15 * (of15 + 1) / 2;
  }

  private static int GetSumMultiples3Or5Old3(int n)
  {
    var multipleOf3  = 0;
    var multipleOf5  = 0;
    var multipleOf15 = 0;

    for (var i = 0; i < n; i = i + 3)
    {
      multipleOf3 = multipleOf3 + i;
    }

    for (var i = 0; i < n; i = i + 5)
    {
      multipleOf5 = multipleOf5 + i;
    }

    for (var i = 0; i < n; i = i + 15)
    {
      multipleOf15 = multipleOf15 + i;
    }

    return multipleOf3 + multipleOf5 - multipleOf15;
  }

  private static int GetSumMultiples3Or5Old2(int n)
  {
    var sum         = 0;
    var multipleOf3 = 1;
    var multipleOf5 = 1;

    for (var i = 1; i < n; i++)
    {
      if (multipleOf3 == 3 || multipleOf5 == 5)
      {
        sum = sum + i;
      }

      multipleOf3++;
      multipleOf5++;
      if (multipleOf3 == 4)
      {
        multipleOf3 = 1;
      }

      if (multipleOf5 == 6)
      {
        multipleOf5 = 1;
      }
    }

    return sum;
  }

  private static int GetSumMultiples3Or5Old1(int n)
  {
    var sum = 0;

    for (var i = 1; i < n; i++)
    {
      if (i % 3 == 0 || i % 5 == 0)
      {
        sum = sum + i;
      }
    }

    return sum;
  }
}

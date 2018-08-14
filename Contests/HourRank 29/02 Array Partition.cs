// FINALLY Runtime Error  :'(

namespace HourRank_29
{
  using System.CodeDom.Compiler;
  using System.Collections.Generic;
  using System.Collections;
  using System.ComponentModel;
  using System.Diagnostics.CodeAnalysis;
  using System.Globalization;
  using System.IO;
  using System.Linq;
  using System.Reflection;
  using System.Runtime.Serialization;
  using System.Text.RegularExpressions;
  using System.Text;
  using System;

  class Array_Partition

  {
    // Complete the solve function below.
    static int solve(List<int> a)
    {
      var ways = 0;

      // Get combinations
      // Taken from: https://stackoverflow.com/questions/7802822/all-possible-combinations-of-a-list-of-values
      var count = Math.Pow(2, a.Count);
      for (int i = 1; i <= count - 1; i++)
      {
        var pList = new List<int>();
        var str   = Convert.ToString(i, 2).PadLeft(a.Count, '0');
        for (int j = 0; j < str.Length; j++)
        {
          if (str[j] == '1')
          {
            pList.Add(a[j]);
          }
        }

        // Now get List Q
        if (pList.Count <= 1 || pList.Count >= a.Count) continue;
        var qList = new List<int>(a);
        foreach (var itemInA in pList)
        {
          if (qList.Contains(itemInA))
          {
            qList.Remove(itemInA);
          }
        }

        // I have 2 lists now get the multiplications
        var multiplicationP = 1;
        for (var k = 0; k < pList.Count; k++)
        {
          multiplicationP = pList[k] * pList[k + 1];
        }

        var multiplicationQ = 1;
        for (var k = 0; k < qList.Count; k++)
        {
          multiplicationQ = qList[k] * qList[k + 1];
        }

        // Now get the gcd
        var myGcd = GCD(multiplicationP, multiplicationQ);

        // Finally
        if (myGcd == 1)
        {
          ways++;
        }
      }

      return ways;
    }


    // Taken from https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor
    private static int GCD(int a, int b)
    {
      while (a != 0 && b != 0)
      {
        if (a > b)
          a %= b;
        else
          b %= a;
      }

      return a == 0 ? b : a;
    }

    static void Main(string[] args)
    {
      // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int t = Convert.ToInt32(Console.ReadLine().Trim());

      for (int tItr = 0; tItr < t; tItr++)
      {
        int aCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = solve(a);

        Console.WriteLine(result);
        // textWriter.WriteLine(result);
      }

      // textWriter.Flush();
      // textWriter.Close();
    }
  }
}

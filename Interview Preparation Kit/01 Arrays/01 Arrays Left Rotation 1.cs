using System.Collections.Generic;
using System.IO;
using System;


// Terminated due to timeout :(
// HACKER RANK > FAILED CASE 8 & 9
// ------------------------------- 

// ReSharper disable once CheckNamespace
// ReSharper disable once ArrangeTypeModifiers
class ArraysLeftRotation1
{
  // Complete the rotLeft function below.
  private static IEnumerable<int> RotLeft(int[] a, int d)
  {
    for (var i = 0; i < d; i++)
    {
      var tempArray = new int[a.Length];
      var tempNum   = a[0];
      Array.Copy(a, 1, tempArray, 0, a.Length - 1);
      tempArray[a.Length - 1] = tempNum;
      a                       = tempArray;
    }

    return a;
  }

  static void MainArraysLeftRotation1(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    string[] nd = Console.ReadLine().Split(' ');

    int n = Convert.ToInt32(nd[0]);

    int d = Convert.ToInt32(nd[1]);

    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
      ;
    IEnumerable<int> result = RotLeft(a, d);

    textWriter.WriteLine(string.Join(" ", result));

    textWriter.Flush();
    textWriter.Close();
  }
}

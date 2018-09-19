using System.Collections.Generic;
using System.IO;
using System;


// Terminated due to timeout :(
// HACKER RANK > FAILED CASE 8 & 9
// ------------------------------- 

// ReSharper disable once CheckNamespace
// ReSharper disable once ArrangeTypeModifiers
class ArraysLeftRotation2
{
  // Complete the rotLeft function below.
  private static IEnumerable<int> RotLeft(int[] a, int d)
  {
    var newIni = new int[a.Length - d];
    var newEnd = new int[d];
    Array.Copy(a, d, newIni, 0, a.Length - d);
    Array.Copy(a, 0, newEnd, 0, d);

    var finalArray = new int[newIni.Length + newEnd.Length];
    newIni.CopyTo(finalArray, 0);
    newEnd.CopyTo(finalArray, newIni.Length);

    return finalArray;
  }

  static void MainArraysLeftRotation2(string[] args)
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

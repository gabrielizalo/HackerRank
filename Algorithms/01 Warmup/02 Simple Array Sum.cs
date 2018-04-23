// --------------------------------------------------------------------------------------------------------------------
// <copyright file="02 Simple Array Sum.cs">
//   Created by Gabriel Porras
// </copyright>
// <summary>
//   Given an array of  integers, can you find the sum of its elements?
//   Input Format
//   The first line contains an integer, , denoting the size of the array.
//   The second line contains  space-separated integers representing the array's elements.
//   Output Format
//   Print the sum of the array's elements as a single integer.
//   Sample Input
//   6
//   1 2 3 4 10 11
//   Sample Output
//   31
//   Explanation
//   We print the sum of the array's elements, which is: 1+2+3+4+10+11=31.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Algorithms._01_Warmup
{
  // ReSharper disable once ClassNeverInstantiated.Global
  public partial class Solution
  {
    private static void Main0102(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      string[] arr_temp = Console.ReadLine().Split(' ');
      int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
      int sum = 0;

      for (int i = 0; i < n; i++)
      {
        sum += arr[i];
      }
      Console.WriteLine(sum);
    }
  }
}

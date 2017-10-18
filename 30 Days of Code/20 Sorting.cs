namespace _30_Days_of_Code
{
  using System;

  public partial class Solution
  {
    static void Main20(String[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      string[] a_temp = Console.ReadLine().Split(' ');
      int[] a = Array.ConvertAll(a_temp, Int32.Parse);

      // Write Your Code Here
      ///////////////////////

      // Vars
      int numTotalSwaps = 0;

      // The Buble Sort code
      for (int i = 0; i < n; i++)
      {
        // Track number of elements swapped during a single array traversal
        int numberOfSwaps = 0;

        for (int j = 0; j < n - 1; j++)
        {
          // Swap adjacent elements if they are in decreasing order
          if (a[j] <= a[j + 1]) continue;
          int temp = a[j];
          a[j] = a[j + 1];
          a[j + 1] = temp;
          numberOfSwaps++;
          numTotalSwaps++;
        }

        // If no elements were swapped during a traversal, array is sorted
        if (numberOfSwaps == 0)
        {
          break;
        }
      }

      // Finally
      Console.WriteLine("Array is sorted in {0} swaps.", numTotalSwaps);
      Console.WriteLine("First Element: {0}", a[0]);
      Console.WriteLine("Last Element: {0}", a[n-1]);
    }
  }
}

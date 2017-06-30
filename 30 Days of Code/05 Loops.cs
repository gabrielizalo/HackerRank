// --------------------------------------------------------------------------------------------------------------------
// <copyright file="05 Loops.cs" company="AxiomaX">
//   Created by Gabriel
// </copyright>
// <summary>
//   Defines the Solution type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _30_Days_of_Code
{
  using System;

  /// <summary>
  /// The solution.
  /// </summary>
  // ReSharper disable once PartialTypeWithSinglePart
  public partial class Solution
  {
    /// <summary>
    /// The main
    /// </summary>
    /// <param name="args">
    /// The args.
    /// </param>
    public static void Main02 ( string[] args )
    {
      // Get the input
      int n = Convert.ToInt32 ( Console.ReadLine () );

      // Process
      for ( int i = 1; i <= 10; i++ )
      {
        Console.WriteLine ( @"{0} x {1} = {2}", n, i, n * i );
      }
    }
  }
}

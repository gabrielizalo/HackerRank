// --------------------------------------------------------------------------------------------------------------------
// <copyright file="09 Recursion.cs" company="AxiomaX">
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
  public partial class Solution
  {
    /// <summary>
    /// The main.
    /// </summary>
    /// <param name="args">
    /// The args.
    /// </param>
    public static void Main09 ( string[] args )
    {
      // Get the input
      int numberToFactorial = Convert.ToInt32 ( Console.ReadLine () );
      int myFactorial       = Factorial ( numberToFactorial );
      Console.WriteLine ( myFactorial );
    }

    /// <summary>
    /// The factorial.
    /// </summary>
    /// <param name="numberToFactorial">
    /// The number to factorial.
    /// </param>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    private static int Factorial ( int numberToFactorial )
    {
      return numberToFactorial >= 2 ? numberToFactorial * Factorial ( numberToFactorial - 1 ) : 1;
    }
  }
}
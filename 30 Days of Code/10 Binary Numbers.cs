// --------------------------------------------------------------------------------------------------------------------
// <copyright file="10 Binary Numbers.cs" company="AxiomaX">
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
    public static void Main10 ( string[] args )
    {
      // Read the number
      int n = Convert.ToInt32 ( Console.ReadLine () );

      // Convert it to base 2
      string asBase2 = Convert.ToString ( n, 2 );

      // Now count the consecutive 1s
      int consecutive    = 0;
      int maxConsecutive = 0;

      foreach ( char myBit in asBase2 )
      {
        if ( myBit == '1' )
        {
          consecutive++;
        }
        else
        {
          maxConsecutive = Math.Max ( consecutive, maxConsecutive );
          consecutive = 0;
        }
      }

      // Finally
      maxConsecutive = Math.Max ( consecutive, maxConsecutive );
      Console.WriteLine ( maxConsecutive );
    }
  }
}

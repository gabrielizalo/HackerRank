// --------------------------------------------------------------------------------------------------------------------
// <copyright file="07 Arrays.cs" company="AxiomaX">
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
    public static void Main07 ( string[] args )
    {
      // Get the input
      int n           = Convert.ToInt32 ( Console.ReadLine () );
      string readLine = Console.ReadLine ();

      if ( readLine == null )
      {
        return;
      }

      string[] arrTemp = readLine.Split ( ' ' );
      int[] arr        = Array.ConvertAll ( arrTemp, int.Parse );

      // The process
      for ( int i = n - 1; i >= 0; i-- )
      {
        Console.Write ( $"{arr [i]} " );
      }
    }
  }
}

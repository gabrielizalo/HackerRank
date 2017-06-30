// --------------------------------------------------------------------------------------------------------------------
// <copyright file="11 2D Arrays.cs" company="AxiomaX">
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
    public static void Main11 ( string[] args )
    {
      int[][] arr = new int[6][];
      for ( int arrI = 0; arrI < 6; arrI++ )
      {
        string readLine = Console.ReadLine ();
        if ( readLine == null )
        {
          continue;
        }

        string[] arrTemp = readLine.Split ( ' ' );
        arr [arrI] = Array.ConvertAll ( arrTemp, int.Parse );
      }
    }
  }
}

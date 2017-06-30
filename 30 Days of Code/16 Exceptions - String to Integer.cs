// --------------------------------------------------------------------------------------------------------------------
// <copyright file="16 Exceptions - String to Integer.cs" company="AxiomaX">
//   Created by Gabriel Porras
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
    /// The main 16.
    /// </summary>
    /// <param name="args">
    /// The args.
    /// </param>
    public static void Main16 ( string[] args )
    {
      string myString = Console.ReadLine ();
      if ( string.IsNullOrWhiteSpace ( myString ) )
      {
        return;
      }

      try
      {
        int myInt = int.Parse ( myString );
        Console.WriteLine ( myInt );
      }
      catch ( FormatException )
      {
        Console.WriteLine ( "Bad String" );
      }
    }
  }
}

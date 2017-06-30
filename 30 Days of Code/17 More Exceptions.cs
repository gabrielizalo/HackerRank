// --------------------------------------------------------------------------------------------------------------------
// <copyright file="17 More Exceptions.cs" company="AxiomaX">
//   Created by Gabriel Porras
// </copyright>
// <summary>
//   Defines the Calculator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _30_Days_of_Code
{
  using System;

  /// <summary>
  /// The calculator.
  /// </summary>
  public class Calculator
  {
    /// <summary>
    /// The power.
    /// </summary>
    /// <param name="numberA">
    /// The number a.
    /// </param>
    /// <param name="numberB">
    /// The number b.
    /// </param>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// n and p should be non-negative
    /// </exception>
    public int Power ( int numberA, int numberB )
    {
      if ( numberA < 0 || numberB < 0 )
      {
        throw new ArgumentException ( "n and p should be non-negative" );
      }

      return (int)Math.Pow ( numberA, numberB );
    }
  }

  /// <summary>
  /// The solution.
  /// </summary>
  // ReSharper disable once StyleCop.SA1402
  public partial class Solution
  {
    /// <summary>
    /// The main.
    /// </summary>
    /// <param name="args">
    /// The args.
    /// </param>
    public static void Main17 ( string[] args )
    {
      Calculator myCalculator = new Calculator ();
      string myReadLine       = Console.ReadLine ();

      if ( myReadLine == null )
      {
        return;
      }

      int i = int.Parse ( myReadLine );

      while ( i-- > 0 )
      {
        myReadLine = Console.ReadLine ();
        if ( string.IsNullOrWhiteSpace ( myReadLine ) )
        {
          continue;
        }

        string [] num = myReadLine.Split ();
        int n         = int.Parse ( num [0] );
        int p         = int.Parse ( num [1] );

        try
        {
          int ans = myCalculator.Power ( n, p );
          Console.WriteLine ( ans );
        }
        catch ( Exception e )
        {
          Console.WriteLine ( e.Message );
        }
      }
    }
  }
}

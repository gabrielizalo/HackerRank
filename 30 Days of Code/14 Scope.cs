// --------------------------------------------------------------------------------------------------------------------
// <copyright file="14 Scope.cs" company="Axioma X">
//   Created by Gabriel
// </copyright>
// <summary>
//   Defines the Difference type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _30_Days_of_Code
{
  using System;
  using System.Linq;

  /// <summary>
  /// The difference.
  /// </summary>
  public class Difference
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Difference"/> class.
    /// </summary>
    public Difference ()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Difference"/> class.
    /// </summary>
    /// <param name="elements">
    /// The elements.
    /// </param>
    public Difference ( int[] elements )
    {
      this.Elements = elements;
    }

    /// <summary>
    /// Gets the elements.
    /// </summary>
    public int[] Elements { get; }

    /// <summary>
    /// Gets or sets the maximum difference.
    /// </summary>
    public int MaximumDifference { get; set; }

    /// <summary>
    /// The compute difference.
    /// </summary>
    public void ComputeDifference ()
    {
      this.MaximumDifference = 0;
      for ( int i = 0; i < this.Elements.Length - 1; i++ )
      {
        for ( int j = i + 1; j < this.Elements.Length; j++ )
        {
          int tempDiff           = this.AbsoluteDifference ( this.Elements [i], this.Elements [j] );
          this.MaximumDifference = Math.Max ( tempDiff, this.MaximumDifference );
        }
      }
    }

    /// <summary>
    /// The absolute difference.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    private int AbsoluteDifference ( int a, int b )
    {
      return Math.Abs ( a - b );
    }
  } // End of Difference Class

  /// <summary>
  /// The solution.
  /// </summary>
  // ReSharper disable once StyleCop.SA1402
  public partial class Solution
  {
    /// <summary>
    /// The main 14.
    /// </summary>
    /// <param name="args">
    /// The args.
    /// </param>
    public static void Main14 ( string[] args )
    {
      string readLine = Console.ReadLine ();
      if ( readLine == null )
      {
        return;
      }

      int [] a = readLine.Split ( ' ' ).Select ( x => Convert.ToInt32 ( x ) ).ToArray ();

      Difference d = new Difference ( a );

      d.ComputeDifference ();

      Console.Write ( d.MaximumDifference );
    }
  }
}

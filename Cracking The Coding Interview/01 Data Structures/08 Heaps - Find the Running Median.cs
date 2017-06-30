// --------------------------------------------------------------------------------------------------------------------
// <copyright file="08 Heaps - Find the Running Median.cs" company="Axioma X">
//   Created by Gabriel Porras
// </copyright>
// <summary>
//   Defines the Solution type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Cracking_The_Coding_Interview._01_Data_Structures
{
  using System;

  /// <summary>
  /// The solution.
  /// </summary>
  // ReSharper disable once PartialTypeWithSinglePart
  public partial class Solution
  {
    /// <summary>
    /// The main.
    /// </summary>
    /// <param name="args">
    /// The args.
    /// </param>
    public static void Main ( string[] args )
    {
      // Init
      int n            = Convert.ToInt32 ( Console.ReadLine () );
      int realLength   = 0;
      int[] myIntArray = new int[n];

      // The process
      for ( int i = 0; i < n; i++ )
      {
        string strNumber = Console.ReadLine ();
        if ( !string.IsNullOrWhiteSpace ( strNumber ) )
        {
          int myNewNumber = int.Parse ( strNumber );
          myIntArray      = InsertOrdered ( myIntArray, realLength, myNewNumber );
        }

        realLength++;

        var myMedian = CalculateMedian ( myIntArray, realLength );
        Console.WriteLine ( myMedian.ToString ( "N1" ) );
      }
    }

    /// <summary>
    /// The insert ordered.
    /// </summary>
    /// <param name="myIntArray">
    /// The my int array.
    /// </param>
    /// <param name="realLength">
    /// The real length.
    /// </param>
    /// <param name="myNewNumber">
    /// The my new number.
    /// </param>
    /// <returns>
    /// The integer list sorted
    /// </returns>
    private static int[] InsertOrdered ( int[] myIntArray, int realLength, int myNewNumber )
    {
      // There is a Ordered Data Structure in c#: SortedList. But for exercise I'll do it manually

      // The first int
      if ( realLength == 0 )
      {
        myIntArray [0] = myNewNumber;
        return myIntArray;
      }

      // The other int

      // First found the pos where it must be inserted
      int myNumberPos = realLength / 2;
      while ( myIntArray [myNumberPos] > myNewNumber && myNumberPos < realLength - 1 )
      {
        myNumberPos = myNumberPos + ( realLength / 2 );
      }

      // Second verify position
      if ( myIntArray [myNumberPos] < myNewNumber )
      {
        myNumberPos++;
      }

      // Third move the array
      int[] firstArrPart  = new int[myNumberPos + 1];
      int[] secondArrPart = new int[myIntArray.Length - myNumberPos];
      Array.Copy ( myIntArray, 0, firstArrPart, 0, myNumberPos );
      Array.Copy ( myIntArray, myNumberPos, secondArrPart, 0, myIntArray.Length - myNumberPos );
      firstArrPart [myNumberPos] = myNewNumber;

      // Finally join the arrays and return it
      myIntArray = new int[firstArrPart.Length + secondArrPart.Length];
      Array.Copy ( firstArrPart, myIntArray, firstArrPart.Length );
      Array.Copy ( secondArrPart, 0, myIntArray, firstArrPart.Length, secondArrPart.Length );
      return myIntArray;
    }

    /// <summary>
    /// The calculate median.
    /// </summary>
    /// <param name="myIntArray">
    /// The my int array.
    /// </param>
    /// <param name="realLength">
    /// The real length.
    /// </param>
    /// <returns>
    /// The <see cref="float"/>.
    /// </returns>
    private static float CalculateMedian ( int[] myIntArray, int realLength )
    {
      int iniPos;
      float myMedian;

      if ( realLength < 1 )
      {
        return 0;
      }

      if ( IsOdd ( realLength ) )
      {
        iniPos   = realLength / 2;
        myMedian = myIntArray [iniPos];
      }
      else
      {
        iniPos   = ( realLength / 2 ) - 1;
        myMedian = (float)( myIntArray [iniPos] + myIntArray [iniPos + 1] ) / 2;
      }

      return myMedian;
    }

    /// <summary>
    /// The is odd.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <returns>
    /// The <see cref="bool"/>.
    /// </returns>
    private static bool IsOdd ( int value )
    {
      return value % 2 != 0;
    }
  }
}

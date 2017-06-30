// --------------------------------------------------------------------------------------------------------------------
// <copyright file="08 Dictionaries and Maps.cs" company="AxiomaX">
//   Created by Gabriel
// </copyright>
// <summary>
//   Defines the Solution type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _30_Days_of_Code
{
  using System;
  using System.Collections.Generic;

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
    public static void Main08 ( string[] args )
    {
      // Get the input
      int n = Convert.ToInt32 ( Console.ReadLine () );
      Dictionary <string, string> myPhoneBook = new Dictionary <string, string> ();

      // Loop to read phone numbers
      for ( int i = 0; i < n; i++ )
      {
        string readLine = Console.ReadLine ();
        if ( readLine == null )
        {
          continue;
        }

        string[] phoneEntry = readLine.Split ( ' ' );
        string name         = phoneEntry [0];
        string phone        = phoneEntry [1];

        // Store the phone number
        myPhoneBook.Add ( name, phone );
      }

      // Loop to search in the Phone book
      string userQuery = Console.ReadLine ();
      while ( !string.IsNullOrWhiteSpace ( userQuery ) )
      {
        Console.WriteLine (
          myPhoneBook.ContainsKey ( userQuery ) ? $"{userQuery}={myPhoneBook [userQuery]}" : "Not found" );

        userQuery = Console.ReadLine ();
      }
    }
  }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="15 Linked List.cs" company="AxiomaX">
//   Created by Gabriel Porras
// </copyright>
// <summary>
//   Defines the Node type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _30_Days_of_Code
{
  using System;

  /// <summary>
  /// The node.
  /// </summary>
  public class Node
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Node"/> class.
    /// </summary>
    /// <param name="d">
    /// The d.
    /// </param>
    public Node ( int d )
    {
      this.Data = d;
      this.Next = null;
    }

    /// <summary>
    /// Gets the data.
    /// </summary>
    public int Data
    {
      get;
    }

    /// <summary>
    /// Gets or sets the next.
    /// </summary>
    public Node Next
    {
      get; set;
    }
  }

  /// <summary>
  /// The solution.
  /// </summary>
  // ReSharper disable once StyleCop.SA1402
  public partial class Solution
  {
    /// <summary>
    /// The insert.
    /// </summary>
    /// <param name="head">
    /// The head.
    /// </param>
    /// <param name="data">
    /// The data.
    /// </param>
    /// <returns>
    /// The <see cref="Node"/>.
    /// </returns>
    public static Node Insert ( Node head, int data )
    {
      Node myNode = new Node ( data );

      if ( head == null )
      {
        return myNode;
      }

      Node myHead     = head;
      Node myLastNode = head;

      myHead = myHead.Next;
      while ( myHead != null )
      {
        myHead     = myHead.Next;
        myLastNode = myLastNode.Next;
      }

      myLastNode.Next = myNode;
      return head;
    }

    /// <summary>
    /// The display.
    /// </summary>
    /// <param name="head">
    /// The head.
    /// </param>
    public static void Display ( Node head )
    {
      Node start = head;
      while ( start != null )
      {
        Console.Write ( start.Data + " " );
        start = start.Next;
      }
    }

    /// <summary>
    /// The main 15.
    /// </summary>
    /// <param name="args">
    /// The args.
    /// </param>
    public static void Main15 ( string[] args )
    {
      Node head       = null;
      string readLine = Console.ReadLine ();

      if ( readLine == null )
      {
        return;
      }

      int i = int.Parse ( readLine );
      while ( i-- > 0 )
      {
        readLine = Console.ReadLine ();
        if ( readLine == null )
        {
          continue;
        }

        int data = int.Parse ( readLine );
        head     = Insert ( head, data );
      }

      Display ( head );
    }
  }
}

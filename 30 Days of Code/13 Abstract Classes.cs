// --------------------------------------------------------------------------------------------------------------------
// <copyright file="13 Abstract Classes.cs" company="AxiomaX">
//   Created by Gabriel
// </copyright>
// <summary>
//   Defines the Book type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _30_Days_of_Code
{
  using System;
  using System.Diagnostics.CodeAnalysis;

  /// <summary>
  /// The book.
  /// </summary>
  [SuppressMessage ("StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here." )]
  public abstract class Book
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Book"/> class.
    /// </summary>
    /// <param name="t">
    /// The t.
    /// </param>
    /// <param name="a">
    /// The a.
    /// </param>
    protected Book ( string t, string a )
    {
      this.Title = t;
      this.Author = a;
    }

    /// <summary>
    /// Gets the title.
    /// </summary>
    protected string Title { get; }

    /// <summary>
    /// Gets the author.
    /// </summary>
    protected string Author { get; }

    /// <summary>
    /// The display.
    /// </summary>
    public abstract void Display ();
  }

  /// <summary>
  /// Write MyBook class
  /// </summary>
  // ReSharper disable once StyleCop.SA1402
  public class MyBook: Book
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="MyBook"/> class.
    /// </summary>
    /// <param name="t">
    /// The t.
    /// </param>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="p">
    /// The p.
    /// </param>
    public MyBook ( string t, string a, int p )
      : base ( t, a )
    {
      this.Price = p;
    }

    /// <summary>
    /// Gets the price.
    /// </summary>
    protected int Price { get; }

    /// <summary>
    /// The display.
    /// </summary>
    public override void Display ()
    {
      Console.WriteLine ( "Title: " + this.Title );
      Console.WriteLine ( "Author: " + this.Author );
      Console.WriteLine ( "Price: " + this.Price );
    }
  }

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
    public static void Main13 ( string[] args )
    {
      string title    = Console.ReadLine ();
      string author   = Console.ReadLine ();
      string strPrice = Console.ReadLine ();
      int price;

      if ( !int.TryParse ( strPrice, out price ) )
      {
        price = 0;
      }

      Book newNovel = new MyBook ( title, author, price );
      newNovel.Display ();
    }
  }
}

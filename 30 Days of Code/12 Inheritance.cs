// --------------------------------------------------------------------------------------------------------------------
// <copyright file="12 Inheritance.cs" company="AxiomaX">
//   Created by Gabriel
// </copyright>
// <summary>
//   Defines the Person type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _30_Days_of_Code
{
  using System;
  using System.Diagnostics.CodeAnalysis;
  using System.Linq;

  /// <summary>
  /// The person.
  /// </summary>
  // ReSharper disable once PartialTypeWithSinglePart
  public partial class Person
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    public Person()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    /// <param name="firstName">
    /// The first name.
    /// </param>
    /// <param name="lastName">
    /// The last name.
    /// </param>
    /// <param name="identification">
    /// The identification.
    /// </param>
    public Person( string firstName, string lastName, int identification )
    {
      this.FirstName = firstName;
      this.LastName  = lastName;
      this.Id        = identification;
    }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    protected string LastName { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    protected int Id { get; set; }

    /// <summary>
    /// Gets or sets the first name.
    /// </summary>
    protected string FirstName { get; set; }

    /// <summary>
    /// The print person.
    /// </summary>
    public void PrintPerson ()
    {
      Console.WriteLine ( "Name: " + this.LastName + ", " + this.FirstName + "\nID: " + this.Id );
    }
  }

  /// <summary>
  /// The student.
  /// </summary>
  [SuppressMessage ( "StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed. Suppression is OK here." )]
  public class Student: Person
  {
    /// <summary>
    /// The test scores.
    /// </summary>
    private readonly int[] testScores;

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    public Student ()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    /// <param name="firstName">
    /// A string denoting the Person's first name.
    /// </param>
    /// <param name="lastName">
    /// A string denoting the Person's last name.
    /// </param>
    /// <param name="id">
    /// An integer denoting the Person's ID number.
    /// </param>
    /// <param name="scores">
    /// An array of integers denoting the Person's test scores.
    /// </param>
    public Student ( string firstName, string lastName, int id, int[] scores )
      : base ( firstName, lastName, id )
    {
      this.testScores = new int[scores.Length];
      Array.Copy ( scores, this.testScores, scores.Length );
    }

    /// <summary>
    /// The calculate.
    /// </summary>
    /// <returns>
    /// A character denoting the grade.
    /// </returns>
    public char Calculate ()
    {
      char grade;
      int sum     = this.testScores.Sum ();
      int average = sum / this.testScores.Length;

      if ( average >= 90 )
      {
        grade = 'O';
      }
      else
      {
        if ( average >= 80 )
        {
          grade = 'E';
        }
        else
        {
          if ( average >= 70 )
          {
            grade = 'A';
          }
          else
          {
            if ( average >= 55 )
            {
              grade = 'P';
            }
            else
            {
              grade = average >= 40 ? 'D' : 'T';
            }
          }
        }
      }

      return grade;
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
    public static void Main12 ()
    {
      string readLine = Console.ReadLine ();
      if ( readLine == null )
      {
        return;
      }

      string[] inputs  = readLine.Split ();
      string firstName = inputs [0];
      string lastName  = inputs [1];
      int id           = Convert.ToInt32 ( inputs [2] );
      int numScores    = Convert.ToInt32 ( readLine );
      inputs           = readLine.Split ();
      int[] scores     = new int[numScores];

      for ( int i = 0; i < numScores; i++ )
      {
        scores [i] = Convert.ToInt32 ( inputs [i] );
      }

      Student s = new Student ( firstName, lastName, id, scores );
      s.PrintPerson ();
      Console.WriteLine ( "Grade: " + s.Calculate () + "\n" );
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;

class FindTheAbsentStudents
{
  // Complete the findTheAbsentStudents function below.
  static int[] findTheAbsentStudents(int n, int[] a)
  {
    // Return the list of student IDs of the missing students in increasing order.

    // Create the array of students
    var absentStudents = new List<int>();
    for (var i = 0; i < n; i++)
    {
      absentStudents.Add(i + 1);
    }

    // Search
    foreach (var myStudent in a)
    {
      if (absentStudents.Contains(myStudent))
      {
        absentStudents.Remove(myStudent);
      }
    }

    // Return the students
    return absentStudents.ToArray();
  }

  static void class Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
    int[] result = findTheAbsentStudents(n, a);

    Console.WriteLine(result);
    Console.ReadLine();

//    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//
//    int n = Convert.ToInt32(Console.ReadLine());
//
//    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
//      ;
//    int[] result = findTheAbsentStudents(n, a);
//
//    textWriter.WriteLine(string.Join(" ", result));
//
//    textWriter.Flush();
//    textWriter.Close();
  }
}

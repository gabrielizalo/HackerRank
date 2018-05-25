using System;
using System.Collections.Generic;
using System.IO;

namespace ContestWeekOfCode37
{
  class SuperiorCharacters
  {
    // Complete the maximumSuperiorCharacters function below.
    static long MaximumSuperiorCharacters(int[] freq)
    {
      var myCharactersList = GetCharacters(freq);
      var myPermutations   = GetPermutations(myCharactersList);

      long myMaximumSuperiorCharacters = 0;
      return myMaximumSuperiorCharacters;
    }

    private static object GetPermutations(List<char> myCharactersList)
    {
      var myPermutations = new List<string>();



      return myPermutations;
    }

    private static List<char> GetCharacters(int[] freq)
    {
      var myCharacters = new List<char>();
      for (var i = 0; i < freq.Length; i++)
      {
        if (freq[i] <= 0) continue;

        for (var j = 0; j < freq[i]; j++)
        {
          myCharacters.Add((char) (i + 65));
        }
      }

      return myCharacters;
    }

    static void Main(string[] args)
    {
      int t = Convert.ToInt32(Console.ReadLine());

      for (int tItr = 0; tItr < t; tItr++)
      {
        int[] freq = Array.ConvertAll(Console.ReadLine().Split(' '), freqTemp => Convert.ToInt32(freqTemp))
          ;
        long result = MaximumSuperiorCharacters(freq);

        Console.WriteLine(result);
      }

      Console.ReadLine();


      //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      //int t = Convert.ToInt32(Console.ReadLine());

      //for (int tItr = 0; tItr < t; tItr++)
      //{
      //  int[] freq = Array.ConvertAll(Console.ReadLine().Split(' '), freqTemp => Convert.ToInt32(freqTemp))
      //    ;
      //  long result = MaximumSuperiorCharacters(freq);

      //  textWriter.WriteLine(result);
      //}

      //textWriter.Flush();
      //textWriter.Close();
    }
  }
}

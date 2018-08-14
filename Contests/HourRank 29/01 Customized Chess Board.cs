namespace HourRank_29
{
  using System.CodeDom.Compiler;
  using System.Collections.Generic;
  using System.Collections;
  using System.ComponentModel;
  using System.Diagnostics.CodeAnalysis;
  using System.Globalization;
  using System.IO;
  using System.Linq;
  using System.Reflection;
  using System.Runtime.Serialization;
  using System.Text.RegularExpressions;
  using System.Text;
  using System;

  class Customized_Chess_Board
  {
    // Complete the solve function below.
    static string solve(List<List<int>> board)
    {
      var i       = 0;
      var isValid = true;

      while (isValid && i + 1 < board.Count)
      {
        var j = 0;
        while (isValid && j + 1 < board[i].Count)
        {
          if (board[i][j] == board[i][j + 1] || board[i][j] == board[i + 1][j])
          {
            isValid = false;
          }

          j++;
        }

        i++;
      }

      return isValid ? "Yes" : "No";
    }

    static void Customized_Chess_BoardMain(string[] args)
    {
      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int t = Convert.ToInt32(Console.ReadLine().Trim());

      for (int tItr = 0; tItr < t; tItr++)
      {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> board = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
          board.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(boardTemp => Convert.ToInt32(boardTemp))
                           .ToList());
        }

        string result = solve(board);

        textWriter.WriteLine(result);
      }

      textWriter.Flush();
      textWriter.Close();
    }
  }
}

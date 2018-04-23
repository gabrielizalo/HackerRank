using System;

namespace ContestWeekOfCode37
{
  class SimpleLanguage
  {
    /*
   * Complete the maximumProgramValue function below.
   */
    static long MaximumProgramValue(int n)
    {
      long myProgramValue = 0;

      for (var i = 0; i < n; i++)
      {
        var myLine = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(myLine)) continue;
        myLine = myLine.Trim().ToLower();

        if (!myLine.StartsWith("add") && !myLine.StartsWith("set") && !myLine.Contains(" ")) continue;

        var myInstruction = myLine.Split(' ')[0];
        var myValue       = myLine.Split(' ')[1];

        if (!int.TryParse(myValue, out var intValue)) continue;

        switch (myInstruction)
        {
          case "add":
            if (intValue > 0)
            {
              myProgramValue = myProgramValue + intValue;
            }

            break;

          default:
            if (intValue > myProgramValue)
            {
              myProgramValue = intValue;
            }

            break;
        }
      }

      return myProgramValue;
    }

    static void SimpleLanguageMain(string[] args)
    {
      int  n      = Convert.ToInt32(Console.ReadLine());
      long result = MaximumProgramValue(n);
      Console.WriteLine(result);
      Console.ReadLine();

      //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      //int n = Convert.ToInt32(Console.ReadLine());

      //long result = MaximumProgramValue(n);

      //textWriter.WriteLine(result);

      //textWriter.Flush();
      //textWriter.Close();
    }
  }
}

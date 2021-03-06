using System;
using System.Collections.Generic;

class ChefAndCakes01
{
  static void ChefAndCakesMain01(String[] args)
  {



    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

    // Read Test Cases
    var testCases = Convert.ToInt32(Console.ReadLine()?.Trim());

    for (var i = 0; i < testCases; i++)
    {
      // Read The Other Data
      var bases    = Convert.ToInt32(Console.ReadLine()?.Trim());
      var strAreas = Console.ReadLine()?.Trim();

      if (strAreas == null) continue;

      // Lets process info
      var arrAreas = strAreas.Split(' ');
      Array.Sort(arrAreas);

      // Count duplicates
      var arrAreasCount = new Dictionary<string, int>();
      foreach (var area in arrAreas)
      {
        if (arrAreasCount.ContainsKey(area))
        {
          arrAreasCount[area]++;
        }
        else
        {
          arrAreasCount.Add(area, 1);
        }
      }

      var maxHeight = 0;
      foreach (var areaCount in arrAreasCount)
      {
        maxHeight = Math.Max(areaCount.Value, maxHeight);
      }

      // Finally
      Console.WriteLine(arrAreasCount.Count + " " + maxHeight);
    }



  }
}

using System.Collections.Generic;
using System.IO;
using System;

class SockMerchant1
{
  // Complete the sockMerchant function below.
  static int sockMerchant(int n, int[] ar)
  {
    // Config
    var myPairSocksCounter = 0;
    var mySocks            = new List<Tuple<int, int>>();

    // Loop
    for (var i = 0; i < n; i++)
    {
      var mySock   = ar[i];
      var position = SearchSock(mySocks, mySock);
      if (position == -1)

      {
        // The sock isn't in the Counter. Add it!
        var myNewSock = new Tuple<int, int>(mySock, 1);
        mySocks.Add(myNewSock);
      }
      else
      {
        // There is 1 sock so I made a couple.
        myPairSocksCounter++;
        mySocks.RemoveAt(position);
      }
    }

    // Finally
    // Console.ReadLine();
    return myPairSocksCounter;
  }


  // Search for sock
  private static int SearchSock(IReadOnlyList<Tuple<int, int>> mySocks, int mySock)
  {
    // Config
    var position = -1;
    var i        = 0;

    // Loop
    while (position == -1 && i < mySocks.Count)
    {
      if (mySocks[i].Item1.Equals(mySock))
      {
        position = i;
      }
      i++;
    }

    // Finally
    return position;
  }


  public static void MainSockMerchant1(string[] args)
  {
    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    int n = Convert.ToInt32(Console.ReadLine());

    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
      ;
    int result = sockMerchant(n, ar);

    //textWriter.WriteLine(result);

    //textWriter.Flush();
    //textWriter.Close();
  }
}

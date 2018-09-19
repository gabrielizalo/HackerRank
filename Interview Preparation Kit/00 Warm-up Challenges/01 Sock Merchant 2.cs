using System.Collections.Generic;
using System.IO;
using System;
using System.Collections;

class SockMerchant2
{
  // Complete the sockMerchant function below.
  static int sockMerchant(int n, int[] ar)
  {
    // Config
    var myPairSocksCounter = 0;
    var mySocks            = new Dictionary<int, int>();

    // Loop
    foreach (var mySock in ar)
    {
      if (!mySocks.ContainsKey(mySock))
      {
        // The sock isn't in the Counter. Add it!
        mySocks.Add(mySock, 1);
      }
      else
      {
        // The sock is already. I found a couple!
        myPairSocksCounter++;
        mySocks.Remove(mySock);
      }
    }

    // Finally
    // Console.ReadLine();
    return myPairSocksCounter;
  }


  public static void Main(string[] args)
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

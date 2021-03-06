namespace _30_Days_of_Code
{
  using System;

  public partial class Printer
  {
    /**
    *    Name: PrintArray
    *    Print each element of the generic array on a new line. Do not return anything.
    *    @param A generic array
    **/

    private static void PrintArray<T>(T[] myArray)
    {
      foreach (T myItem in myArray)
      {
        Console.WriteLine(myItem);
      }
    }


    static void Main21(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] intArray = new int[n];
      for (int i = 0; i < n; i++)
      {
        intArray[i] = Convert.ToInt32(Console.ReadLine());
      }

      n = Convert.ToInt32(Console.ReadLine());
      string[] stringArray = new string[n];
      for (int i = 0; i < n; i++)
      {
        stringArray[i] = Console.ReadLine();
      }

      PrintArray<Int32>(intArray);
      PrintArray<String>(stringArray);
    }

  }
}

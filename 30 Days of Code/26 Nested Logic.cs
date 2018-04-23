namespace _30_Days_of_Code
{
  using System;

  public partial class Solution
  {
    static void Main(String[] args)
    {
      // Input Dates
      var actuallyString = Console.ReadLine();
      var expectedString = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(actuallyString) || string.IsNullOrWhiteSpace(expectedString)) return;

      var actuallyDate = ConvertStringToDate(actuallyString);
      var expectedDate = ConvertStringToDate(expectedString);

      // The Fine
      var myFine = CalculateMyFine(expectedDate, actuallyDate);

      // Finally
      Console.WriteLine(myFine);
      Console.ReadLine();
    }

    private static DateTime ConvertStringToDate(string actuallyString)
    {
      var actuallyArray = actuallyString.Split(' ');
      var actuallyDate = new DateTime(int.Parse(actuallyArray[2]),
                                      int.Parse(actuallyArray[1]), int.Parse(actuallyArray[0]));
      return actuallyDate;
    }

    private static int CalculateMyFine(DateTime expectedDate, DateTime actuallyDate)
    {
      var       myFine               = 0;
      const int fimeDaysLateHackos   = 15;
      const int fineMonthsLateHackos = 500;
      const int fineYearsLateHackos  = 10000;

      // Fine Calculation
      if (expectedDate >= actuallyDate) return myFine;

      if (expectedDate.Year != actuallyDate.Year)
      {
        myFine = fineYearsLateHackos;
      }
      else
      {
        if (expectedDate.Month == actuallyDate.Month)
        {
          var numDays = (actuallyDate - expectedDate).Days;
          myFine = fimeDaysLateHackos * numDays;
        }
        else
        {
          var numMonths = (actuallyDate - expectedDate).Days / 30;
          myFine = fineMonthsLateHackos * numMonths;
        }
      }

      return myFine;
    }
  }
}

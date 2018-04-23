using System;

namespace ContestWeekOfCode37
{
  class TheAverageRatingOfTopEmployees
  {
    // Complete the averageOfTopEmployees function below.
    static void AverageOfTopEmployees(int[] rating)
    {
      var myRatingSum   = 0;
      var myRatingCount = 0;

      foreach (var myRating in rating)
      {
        if (myRating < 90) continue;

        myRatingSum = myRatingSum + myRating;
        myRatingCount++;
      }

      var myAverage = Math.Round((float) myRatingSum / myRatingCount, 2, MidpointRounding.AwayFromZero);
      Console.WriteLine(myAverage.ToString("n2"));
      Console.ReadLine();
    }

    static void TheAverageRatingOfTopEmployeesMain(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());

      int[] rating = new int [n];

      for (int ratingItr = 0; ratingItr < n; ratingItr++)
      {
        int ratingItem = Convert.ToInt32(Console.ReadLine());
        rating[ratingItr] = ratingItem;
      }

      AverageOfTopEmployees(rating);
    }
  }
}

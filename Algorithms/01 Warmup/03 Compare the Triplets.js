/**
 * Created by ghporras on 2021 07 15
 */

/*
 * Complete the 'compareTriplets' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER_ARRAY a
 *  2. INTEGER_ARRAY b
 */

function compareTriplets(a, b) {

  const ratings = [0, 0];
  let i = 0;

  while (a.length >= i) {
    if (a[i] > b[i]) {
      ratings[0]++
    } else {
      if (a[i] < b[i]) {
        ratings[1]++
      }
    }

    i++;
  }

  return ratings;
}

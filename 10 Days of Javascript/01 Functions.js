/**
 * Created by gporras on 2018-04-25.
 */

function factorial(myNumber) {
  return !(myNumber === 0 || myNumber === 1) ? myNumber * factorial(myNumber - 1) : 1;
}

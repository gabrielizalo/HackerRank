/**
 * Created by gporras on 2018-08-30.
 */

/*
 * Modify and return the array so that all even elements are doubled and all odd elements are tripled.
 *
 * Parameter(s):
 * nums: An array of numbers.
 */
function modifyArray ( nums ) {
  const multiplyArray = nums.map ( function ( a ) {
    return a % 2 === 0 ? a * 2 : a * 3;
  } );
  return multiplyArray;
}

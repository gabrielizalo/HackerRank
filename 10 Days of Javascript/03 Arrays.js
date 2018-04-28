/**
 * Created by gporras on 2018-04-27.
 */

/**
 *   Return the second largest number in the array.
 *   @param {Number[]} nums - An array of numbers.
 *   @return {Number} The second largest number in the array.
 **/
function getSecondLargest(nums) {
  let myLargestNum1 = nums [0];
  let myLargestNum2 = nums [0];
  for (let i = 1; i < nums.length; i++) {
    // console.log(myLargestNum1 + '-' + myLargestNum2 + '-' + nums[i]);
    if (myLargestNum1 < nums[i]) {
      myLargestNum2 = myLargestNum1;
      myLargestNum1 = nums[i];
    } else if (myLargestNum2 < nums[i] &&  myLargestNum1 > nums[i]) {
      myLargestNum2 = nums[i];
    }
  }

  return myLargestNum2;
}

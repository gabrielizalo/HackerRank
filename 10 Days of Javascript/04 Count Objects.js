/**
 * Created by gporras on 2018-06-15.
 */

/*
 Complete the function in the editor. It has one parameter: an array, a, of objects. Each object in the array has two
 integer properties denoted by x and y. The function must return a count of all such objects o in array a that satisfy
 o*x == o*y.
 */
function getCount(objects) {
  let i = 0;
  for ( let j = 0; j < objects.length; j++ ) {
    if ( objects[j].x === objects[j].y )  {
      i++;
    }
  }
  return i;
}

/**
 * Created by gporras on 2018-04-25.
 */

function main() {
  // Write your code here. Read input using 'readLine()' and print output using 'console.log()'.
  const PI = Math.PI;
  let myRadius = readLine();

  // Print the area of the circle:
  let myArea = PI * myRadius * myRadius;
  console.log(myArea);

  // Print the perimeter of the circle:
  let myPerimeter = 2 * PI * myRadius;
  console.log(myPerimeter);
}

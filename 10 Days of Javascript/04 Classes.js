/**
 * Created by gporras on 2018-06-15.
 */

/*
 Create a Polygon class that has the following properties:

A constructor that takes an array of integer values describing the lengths of the polygon's sides.
A perimeter() method that returns the polygon's perimeter.
Locked code in the editor tests the Polygon constructor and the perimeter method.

Note: The perimeter method must be lowercase and spelled correctly.
 */
/*
 * Implement a Polygon class with the following properties:
 * 1. A constructor that takes an array of integer side lengths.
 * 2. A 'perimeter' method that returns the sum of the Polygon's side lengths.
 */
class Polygon {
  constructor(lenghtsSides) {
    this.lenghtsSides = lenghtsSides;
  }
  perimeter() {
    let myPerimeter = 0;
    for ( let lengthSide of this.lenghtsSides ) {
      myPerimeter = myPerimeter + lengthSide;
    }
    return myPerimeter;
  }
}

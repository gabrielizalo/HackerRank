/**
 * Created by gporras on 2018-08-29.
 */

/*
Objective
In this challenge, we practice implementing inheritance and use JavaScript prototypes to add a new method to an
existing prototype. Check out the attached Classes tutorial to refresh what we've learned about these topics.

Task
We provide the implementation for a Rectangle class in the editor. Perform the following tasks:
1. Add an area method to Rectangle's prototype.
2. Create a Square class that satisfies the following:
   * It is a subclass of Rectangle.
   * It contains a constructor and no other methods.
   * It can use the Rectangle class' area method to print the area of a Square object.

Locked code in the editor tests the class and method implementations and prints the area values to STDOUT.
 */
class Rectangle {
  constructor ( w, h ) {
    this.w = w;
    this.h = h;
  }
}



/* -- MY CODE : INI -- */

/*
 1. Add an area method to Rectangle's prototype.
 */
Rectangle.prototype.area = function () {
  return this.w * this.h;
};

/*
 2. Create a Square class that satisfies the following:
   * It is a subclass of Rectangle.
   * It contains a constructor and no other methods.
   * It can use the Rectangle class' area method to print the area of a Square object.
*/
class Square extends Rectangle {
  constructor ( a ) {
    super ( a, a );
  }
}

/* -- MY CODE : END -- */



if (JSON.stringify(Object.getOwnPropertyNames(Square.prototype)) === JSON.stringify([ 'constructor' ])) {
  const rec = new Rectangle(3, 4);
  const sqr = new Square(3);

  console.log(rec.area());
  console.log(sqr.area());
} else {
  console.log(-1);
  console.log(-1);
}

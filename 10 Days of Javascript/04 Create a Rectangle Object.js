/**
 * Created by gporras on 2018-06-15.
 */

/*
 Complete the function in the editor. It has two parameters: a and b. It must return an object modeling a rectangle that
 has the following properties:
 length: This value is equal to a.
 width: This value is equal to b.
 perimeter: This value is equal to 2*(a+b)
 area: This value is equal to a*b
 */
function Rectangle(a, b) {
  return {
    length: a,
    width: b,
    perimeter: 2*(a + b),
    area: a * b
  };
}

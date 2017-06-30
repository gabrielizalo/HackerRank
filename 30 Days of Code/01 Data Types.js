/**
 * Created by gporras on 12-Oct-16.
 */

// Declare second integer, double, and String variables.
var myInt    = 5;
var myDouble = 5.0;
var myString = "My string";

// Read and save an integer, double, and String to your variables.
myInt    = parseInt ( readLine () );
myDouble = parseFloat ( readLine () );
myString = readLine ();

// Print the sum of both integer variables on a new line.
console.log ( i + myInt );

// Print the sum of the double variables on a new line.
console.log ( ( d + myDouble ).toFixed ( 1 ) );

// Concatenate and print the String variables on a new line
// The 's' variable above should be printed first.
console.log ( s + myString );

/**
 * Created by gporras on 012 12-Oct-16.
 */
function main () {

  var nTemp        = readLine ().split ( ' ' );
  var numItems     = parseInt ( nTemp [0] ); // Number of items in array
  var numToMove    = parseInt ( nTemp [1] ); // Number to move
  var myArray      = readLine ().split ( ' ' );
  // myArray       = myArray.map(Number);

  var arrToMove    = myArray.slice ( 0, numToMove );
  var arrNewBegin  = myArray.slice ( numToMove, numItems );
  var myFinalArray = arrNewBegin.concat ( arrToMove );

  // Print the result
  console.log ( myFinalArray.toString ().replace ( new RegExp ( ",", 'g' ), " " ) );

}

/**
 * Created by Gabriel on 14/oct/2016.
 */
function main () {

  var num = parseInt ( readLine () );

  // Evaluation
  var msg = isOdd ( num ) ? "Weird" : ( num <= 5 || num > 20 ? "Not Weird" : "Weird" );

  // Final
  console.log ( msg );

}

function isOdd ( num ) {
  // Taken from http://stackoverflow.com/questions/5016313/how-to-determine-if-a-number-is-odd-in-javascript
  return num % 2;
}

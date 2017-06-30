/**
 * Created by Gabriel on 17/oct/2016.
 * @param {any} input The input sent
 */
function processData ( input ) {

  // Get the info
  var numberLines = parseInt ( input.split ( "\n" ) [0] );

  // Process
  for ( var i = 0; i < numberLines; i++ ) {

    var myString = input.split ( "\n" ) [i + 1];

    // The process for each string
    var myEvenIndexedStr = "";
    var myOddIndexedStr  = "";

    for ( var j = 0; j < myString.length; j++ ) {

      var myChar = myString [j].toString ();
      if ( j % 2 === 0 ) {
        myOddIndexedStr = myOddIndexedStr + myChar;
      } else {
        myEvenIndexedStr = myEvenIndexedStr + myChar;
      }
    }

    // Final
    console.log ( myOddIndexedStr + " " + myEvenIndexedStr );
  }
}

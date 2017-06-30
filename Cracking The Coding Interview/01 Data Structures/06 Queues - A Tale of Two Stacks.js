/**
 * Created by Gabriel on 14/oct/2016.
 * ERROR.. Review part 2
 */
function processData ( input ) {

  // Get the info
  var myQueries = input.split ( "\n" );
  var numQueries = parseInt ( myQueries [0] );

  // Lets process the queue
  processQueue ( numQueries, myQueries );

}


function processQueue ( numQueries, myQueries ) {

  var myStack = [];
  for ( var i = 1; i <= numQueries; i++ ) {

    var myQuery = myQueries [i];
    var myType = myQuery [0];

    switch ( myType ) {
      case "1":
        myStack.push ( myQuery.split ( " " ) [1] );
        break;

      case "2":
        if ( !isEmpty ( myStack ) ) {
          myStack.shift ();
        }
        break;

      case "3":
        if ( !isEmpty ( myStack ) ) {
          var myItem = myStack.shift ();
          myStack.push ( myItem );
          console.log ( myItem );
        }
        break;

    }

  }

}


function isEmpty ( myQueue ) {

  var size = 0, key;
  for ( key in myQueue ) {
    if ( myQueue.hasOwnProperty ( key ) ) {
      size++;
    }
  }

  return size <= 0;

}

/**
 * Created by Gabriel on 14/oct/2016.
 */
function processData ( input ) {

  // Get the info
  var myQueries = input.split ( "\n" );
  var numQueries = parseInt ( myQueries [0] );

  // Lets process the queue
  processQueue ( numQueries, myQueries );

}


function processQueue ( numQueries, myQueries ) {

  var myStack = new Queue ();
  for ( var i = 1; i <= numQueries; i++ ) {

    var myQuery = myQueries [i];
    var myType = myQuery [0];

    switch ( myType ) {
      case "1":
        myStack.enqueue ( myQuery.split ( " " ) [1] );
        break;

      case "2":
        if ( !myStack.isEmpty () ) {
          myStack.dequeue ();
        }
        break;

      case "3":
        if ( !myStack.isEmpty () ) {
          console.log ( myStack.peek () );
        }
        break;

    }

  }

}


function Queue () {
  // Function taken from code.StephenMorley.org
  // The shift() is terrible. I was getting a lot of errors. With the same logic
  var a = [], b = 0;
  this.getLength = function () {
    return myArray.length - b;
  };
  this.isEmpty = function () {
    return 0 === myArray.length;
  };
  this.enqueue = function ( b ) {
    myArray.push ( b );
  };
  this.dequeue = function () {
    var myArray;
    if ( 0 !== myArray.length ) {
      var c = myArray [b];
      2 * ++b >= myArray.length && ( myArray = myArray.slice ( b ), b = 0 );
      return c
    }
  }

  this.peek = function () {
    return 0 < myArray.length ? myArray [b] : void 0;
  }
};

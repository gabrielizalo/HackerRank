function main () {

  myArray       = readLine ().split ( " " );
  myArray       = myArray.map ( Number );
  numberOfSwaps = 0;

  // Sort Array with Bubble Sort
  bubbleSort ();

  // Problem output
  console.log ( "Array is sorted in numSwaps swaps.".replace ( "numSwaps", numberOfSwaps ) );
  console.log ( "First Element: firstElement".replace ( "firstElement", myArray [0] ) );
  console.log ( "Last Element: lastElement".replace ( "lastElement", myArray [myArray.length - 1] ) );

}


function swap ( pos1, pos2 ) {
  var tmp = myArray [pos1];
  myArray [pos1] = myArray [pos2];
  myArray [pos2] = tmp;
}


function bubbleSort () {
  for ( var i = 0; i < myArray.length; i++ ) {
    // Track number of elements swapped during a single array traversal
    // var numberOfSwaps = 0 ;   This variable is global because: Output Format 1

    for ( var j = 0; j < myArray.length - 1; j++ ) {
      // Swap adjacent elements if they are in decreasing order
      if ( myArray [j] > myArray [j + 1] ) {
        swap ( j, j + 1 );
        numberOfSwaps++;
      }
    }

    // If no elements were swapped during a traversal, array is sorted
    if ( numberOfSwaps === 0 ) {
      return;
    }
  }
}

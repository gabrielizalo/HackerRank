// Const
///////////////
var ARR_ROW_SIZE  = 6;
var ARR_COL_SIZE  = 6;
var MIN_HOURGLASS = -1000;


// getHourGlass
///////////////
function getHourGlass ( arr, i2, j2 ) {


  var myHg;


  // First validate if it is a valid HourGlass
  if ( i2 + 2 >= ARR_COL_SIZE || j2 + 2 >= ARR_ROW_SIZE ) {
    return MIN_HOURGLASS;
  }


  // I have a valid HourGlass. Sum it!
  myHg = 0;
  myHg = myHg + arr [i2] [j2] + + arr [i2 + 2] [j2];
  myHg = myHg + arr [i2] [j2 + 1] + arr [i2 + 1] [j2 + 1] + arr [i2 + 2] [j2 + 1];
  myHg = myHg + arr [i2] [j2 + 2] + + arr [i2 + 2] [j2 + 2];

  // console.log ( "".concat ( i2, " x ", j2 ) );
  // console.log ( "".concat ( arr[ i2 ][ j2 ],     " ", " ",                     " ", arr[ i2 + 2 ][ j2 ]     ) );
  // console.log ( "".concat ( arr[ i2 ][ j2 + 1 ], " ", arr[ i2 + 1 ][ j2 + 1 ], " ", arr[ i2 + 2 ][ j2 + 1 ] ) );
  // console.log ( "".concat ( arr[ i2 ][ j2 + 2 ], " ", " ",                     " ", arr[ i2 + 2 ][ j2 + 2 ] ) );
  // console.log ( myHG );
  // console.log ( " - " );


  //Finally
  return myHg;

}


// getMaxHourGlass
//////////////////
function getMaxHourGlass ( arr ) {


  var myHourGlass;
  var myMaxHourGlass = MIN_HOURGLASS;


  // Loop the array
  for ( var i = 0; i < ARR_ROW_SIZE; i++ ) {

    for ( var j = 0; j < ARR_COL_SIZE; j++ ) {

      myHourGlass = getHourGlass ( arr, i, j );
      if ( myHourGlass > myMaxHourGlass ) {
        myMaxHourGlass = myHourGlass;
      }

    }
  }


  // Finally
  return myMaxHourGlass;


}


// Main
///////
function main () {


  var arr = [];
  for ( var arrI = 0; arrI < ARR_ROW_SIZE; arrI++ ) {
    arr [arrI] = window.readLine ().split ( ' ' );
    arr [arrI] = arr [arrI].map ( Number );
  }


  // Gabriel Porras Code
  var maxHourGlass = getMaxHourGlass ( arr );
  console.log ( maxHourGlass );


}

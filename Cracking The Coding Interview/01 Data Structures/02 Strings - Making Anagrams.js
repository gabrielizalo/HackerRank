/**
 * Created by gporras on 012 12-Oct-16.
 */

function main () {

  // Get init data
  var array1     = readLine ();
  var array2     = readLine ();
  var lenArray1  = array1.length;
  var lenArray2  = array2.length;
  var arrayCopy2 = array2.slice ();


  // Temp vars
  var posRemove;
  var arrTmp1, arrTmp2;
  var numCommonChars1 = 0;
  var numCommonChars2 = 0;


  // First array
  var i;
  for ( i = 0; i < lenArray1; i++ ) {
    posRemove = array2.indexOf ( array1 [i] );
    // console.log ( array1[i] );
    // console.log ( array2 );
    if ( posRemove !== -1 ) {

      numCommonChars1++;

      arrTmp1 = array2.slice ( 0, posRemove );
      arrTmp2 = array2.slice ( posRemove + 1, lenArray2 );
      array2  = arrTmp1.concat ( arrTmp2 );
    }
    // console.log ( numCommonChars1 );
    // console.log ( array2 );
    // console.log ( "---" );
  }


  // Second array
  array2 = arrayCopy2.slice ();
  for ( i = 0; i < lenArray2; i++ ) {
    // console.log ( array2[i] );
    // console.log ( array1 );
    posRemove = array1.indexOf ( array2 [i] );
    if ( posRemove !== -1 ) {

      numCommonChars2++;

      arrTmp1 = array1.slice ( 0, posRemove );
      arrTmp2 = array1.slice ( posRemove + 1, lenArray1 );
      array1  = arrTmp1.concat ( arrTmp2 );
    }
    // console.log ( numCommonChars2 );
    // console.log ( array1 );
    // console.log ( "---" );
  }


  // The result
  console.log ( lenArray1 + lenArray2 - numCommonChars1 - numCommonChars2 );
}

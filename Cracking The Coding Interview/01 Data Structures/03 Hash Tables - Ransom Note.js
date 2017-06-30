/**
 * Created by gporras on 012 12-Oct-16.

TESTS

 6 4
 give me one grand today night
 give one grand today


 15 17
 o l x imjaw bee khmla v o v o imjaw l khmla imjaw x
 imjaw l khmla x imjaw o l l o khmla v bee o o imjaw imjaw o


 15 6
 apgo clm w lxkvg mwz elo bg elo lxkvg elo apgo apgo w elo bg
 elo lxkvg bg mwz clm w


 */


function main () {
  var mTemp       = readLine ().split ( ' ' );
  var magazineLen = parseInt ( mTemp [0] );
  var ransomLen   = parseInt ( mTemp [1] );
  var magazine    = readLine ().split ( " " );
  var ransom      = readLine ().split ( " " );

  // Create hashTables of texts
  var magazineHashTable = createHashTable ( magazine, magazineLen );
  var ransomHashTable   = createHashTable ( ransom, ransomLen );

  // console.log ( magazineHashTable );
  // console.log ( ransomHashTable );

  // Compare hash tables
  var canCreateReplica = compareHashTables ( magazineHashTable, ransomHashTable );
  console.log ( canCreateReplica ? "Yes" : "No" );
}


function createHashTable ( myStringArray, myLen ) {
  var word;
  var myHashTable = {};
  for ( var i = 0; i < myLen; i++ ) {
    word               = myStringArray [i];
    myHashTable [word] = !( word in myHashTable ) ? 1 : myHashTable [word] + 1;
  }
  return myHashTable;
}


function compareHashTables ( magazineHashTable, ransomHashTable ) {
  var word;
  for ( word in ransomHashTable ) {
    if ( ransomHashTable.hasOwnProperty ( word ) ) {
      if ( !( word in magazineHashTable ) || ( ransomHashTable [word] > magazineHashTable [word] ) ) {
        return false;
      }
    }
  }
  return true;
}

/**
 * Created by gporras on 012 12-Oct-16.
 */
// 3
// {[()]}
// {[(])}
// {{[[(())]]}}


function main () {

  var numStrBrackets = readNumber ( readLine () );

  if ( numStrBrackets === null ) {
    console.log ( "First line is not myArray number" );
    return;
  }

  for ( var i = 0; i < numStrBrackets; i++ ) {

    var isBalancedBracket = evaluateBracket ( readLine () );
    console.log ( isBalancedBracket ? "YES" : "NO" );

  }

}

function evaluateBracket ( myStrBrackets ) {

  /**
   * evaluate myArray string of brackets and return if its balanced
   *
   * @myStrBrackets String of brackets
   */

  // Param is OK?
  var areBrackets = evaluateStringOfBrackets ( myStrBrackets );
  if ( !areBrackets ) {
    return false;
  }

  // Evaluate if balanced
  var myChar;
  var myCharOut;
  var myStack = [];

  for ( var j = 0; j < myStrBrackets.length; j++ ) {

    myChar = myStrBrackets [j];
    switch ( myChar ) {
      case "[":
      case "{":
      case "(":
        myStack.push ( myChar );
        break;

      case ")":
        if ( getSize ( myStack ) > 0 ) {
          myCharOut = myStack.pop ();
          if ( myCharOut === "{" || myCharOut === "[" ) {
            return false;
          }
        } else {
          return false;
        }

        break;

      case "}":
        if ( getSize ( myStack ) > 0 ) {
          myCharOut = myStack.pop ();
          if ( myCharOut === "(" || myCharOut === "[" ) {
            return false;
          }
        } else {
          return false;
        }
        break;

      case "]":
        if ( getSize ( myStack ) > 0 ) {
          myCharOut = myStack.pop ();
          if ( myCharOut === "(" || myCharOut === "{" ) {
            return false;
          }
        } else {
          return false;
        }
        break;
    }

  }

  // If myStack is empty all is ok!
  return getSize ( myStack ) === 0;

}


function readNumber ( strNumber ) {
  /**
   * Return myArray string as number if possible.
   * if not return myArray null
   *
   * @strNumber Number as myArray String
   */
  // TODO function
  return parseInt ( strNumber );
}


function evaluateStringOfBrackets ( strBracketsString ) {
  /**
   * Is strBracketsString myArray string of Brackets?
   */
  // TODO function
  return true;
}


function getSize ( obj ) {

  /**
   * Get the size of an Array
   * Taken from: http://stackoverflow.com/questions/5223/length-of-a-javascript-object-or-associative-array
   *
   * @obj {array}
   */
  var size = 0, key;
  for ( key in obj ) {
    if ( obj.hasOwnProperty ( key ) ) {
      size++;
    }
  }
  return size;

}

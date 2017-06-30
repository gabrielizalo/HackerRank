function processData ( input ) {

  // Get the info
  var mealCost   = parseFloat ( input.split ( "\n" ) [0] );
  var tipPercent = parseFloat ( input.split ( "\n" ) [1] );
  var taxPercent = parseFloat ( input.split ( "\n" ) [2] );

  // Lets calculate
  var tip        = mealCost * ( tipPercent / 100 );
  var tax        = mealCost * ( taxPercent / 100 );
  var totalCost  = Math.round ( mealCost + tip + tax );

  // Print result
  console.log ( "The total meal cost is " + totalCost + " dollars." );

}

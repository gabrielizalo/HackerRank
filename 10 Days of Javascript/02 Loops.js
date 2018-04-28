/**
 * Created by gporras on 2018-04-27.
 */

/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
  let myVowels     = [];
  let myConsonants = [];

  for (let i = 0; i < s.length; i++) {
    switch (s[i]) {
      case 'a':
      case 'e':
      case 'i':
      case 'o':
      case 'u':
        myVowels.push(s[i]);
        break;
      default:
        myConsonants.push(s[i]);
        break;
    }
  }

  for (let i = 0; i < myVowels.length; i++) {
    console.log(myVowels[i]);
  }

  for (let i = 0; i < myConsonants.length; i++) {
    console.log(myConsonants[i]);
  }
}


// Best Solution: Only 1 Loop
function vowelsAndConsonants(s) {
  const vowels   = 'aeiou';
  var consonants = '';

  for (var i = 0; i < s.length; i++) {
    if (vowels.includes(s[i])) {
      console.log(s[i]);
    }
    else {
      consonants += s[i] + '\n';
    }
  }

  console.log(consonants.trim());
}


// Preferred Solution: Only 1 Loop
function vowelsAndConsonants(s) {
  const vowels     = 'aeiou';
  let myVowels     = '';
  let myConsonants = '';

  for (let i = 0; i < s.length; i++) {
    if (vowels.includes(s[i])) {
      myVowels += s[i] + '\n';
    }
    else {
      myConsonants += s[i] + '\n';
    }
  }

  console.log(myVowels.trim());
  console.log(myConsonants.trim());
}


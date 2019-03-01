'use strict';

console.log('start');

//https://www.codewars.com/kata/thinkful-number-drills-blue-and-red-marbles/train/javascript
function guessBlue(blueStart, redStart, bluePulled, redPulled) {
	var a = blueStart - bluePulled;
	var b = blueStart + redStart - bluePulled - redPulled;
	return a / b;
}

console.log('end');

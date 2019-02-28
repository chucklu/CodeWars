'use strict';

console.log('start');

//https://www.codewars.com/kata/who-is-going-to-pay-for-the-wall/train/javascript
function whoIsPaying(name) {
	if (name.length <= 2) {
		return [name];
	} else {
		return [name, name.substring(0, 2)];
	}
}

console.log('end');

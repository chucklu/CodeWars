'use strict';

console.log('start');

//https://www.codewars.com/kata/pillars/train/javascript
function pillars(num_pill, dist, width) {
	if (num_pill === 1) {
		return 0;
	}
	return (num_pill - 1) * dist * 100 + (num_pill - 2) * width;
}

console.log('end');

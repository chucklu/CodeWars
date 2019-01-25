'use strict';

console.log('start');

//https://www.codewars.com/kata/count-odd-numbers-below-n/train/javascript
function oddCount(n) {
    if (n % 2 === 0) {
        n = n + 1;
    }
    return (n - 1) / 2;
}

console.log('end');

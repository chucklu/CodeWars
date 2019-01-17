'use strict';

console.log('start');

//https://www.codewars.com/kata/find-the-integral/train/javascript
function integrate(coefficient, exponent) {
    var n = exponent + 1;
    var k = coefficient / n;
    return `${k}x^${n}`;
}

console.log('end');

'use strict';

console.log('start');

//https://www.codewars.com/kata/will-there-be-enough-space/train/javascript
function enough(cap, on, wait) {
    var left = cap - on;
    var out = wait - left;
    if (out < 0) {
        out = 0;
    }
    return out;
}

console.log('end');

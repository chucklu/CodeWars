'use strict';

console.log('start');

//https://www.codewars.com/kata/is-this-my-tail/train/javascript
function correctTail(body, tail) {
    var sub = body.substr(body.length - tail.length);
    if (sub === tail) {
        return true;
    } else {
        return false;
    }
}

console.log('end');

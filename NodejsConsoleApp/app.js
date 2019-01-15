'use strict';

console.log('start');

https://www.codewars.com/kata/reversed-sequence/train/javascript
const reverseSeq = n => {
    var temp = [...Array(n + 1).keys()].reverse();
    temp.pop();
    return temp;
};

console.log('end');

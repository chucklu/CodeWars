'use strict';

console.log('start');

var result = sumMix([5]);
console.log(result);

//https://www.codewars.com/kata/sum-mixed-array/train/javascript
function getSum(total, num) {
    total = parseInt(total);
    num = parseInt(num);
    return total + num;
}

function sumMix(array) {
    var total = array.reduce(getSum);
    total = parseInt(total);
    return total;
}

console.log('end');

'use strict';

console.log('start');

var result = capitalizeWord('word');
console.log(result);
//https://www.codewars.com/kata/capitalization-and-mutability/train/javascript
//https://stackoverflow.com/questions/1026069/how-do-i-make-the-first-letter-of-a-string-uppercase-in-javascript
function capitalizeWord(word) {
    return word[0].toUpperCase() + word.slice(1);
}

console.log('end');

//https://www.codewars.com/kata/l1-set-alarm/train/javascript
function setAlarm(employed, vacation) {
    if (!employed) {
        return false;
    } else {
        return !vacation;
    }
}
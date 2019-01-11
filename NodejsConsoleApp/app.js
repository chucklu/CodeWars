'use strict';

console.log('Hello world');

//https://www.codewars.com/kata/l1-set-alarm/train/javascript
function setAlarm(employed, vacation) {
    if (!employed) {
        return false;
    } else {
        return !vacation;
    }
}
'use strict';

console.log('start');

//https://www.codewars.com/kata/return-the-day/train/javascript
function whatday(num) {
    var result = 'Wrong, please enter a number between 1 and 7';
    switch (num) {
    case 1:
        result = "Sunday";
        break;
    case 2:
        result = "Monday";
        break;
    case 3:
        result = "Tuesday";
        break;
    case 4:
        result = "Wednesday";
        break;
    case 5:
        result = "Thursday";
        break;
    case 6:
        result = "Friday";
        break;
    case 7:
        result = "Saturday";
        break;
    }
    return result;
}

console.log('end');

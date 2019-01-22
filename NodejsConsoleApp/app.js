'use strict';

console.log('start');

//https://www.codewars.com/kata/is-the-date-today/train/javascript
function isToday(date) {
    var today = new Date();
    var date1 = new Date(Date.UTC(date.getFullYear(), date.getMonth(), date.getDate()));
    var date2 = new Date(Date.UTC(today.getFullYear(), today.getMonth(), today.getDate()));
    return date1.getTime() === date2.getTime();
}

console.log('end');

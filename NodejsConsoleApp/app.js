'use strict';

console.log('start');

//https://www.codewars.com/kata/abbreviate-a-two-word-name/train/javascript
function abbrevName(name) {
    var array = name.split(' ');
    var first = array[0].charAt(0).toUpperCase();
    var last = array[1].charAt(0).toUpperCase();
    return `${first}.${last}`;
}

console.log('end');

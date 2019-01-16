'use strict';

console.log('start');

//https://www.codewars.com/kata/filter-out-the-geese/train/javascript
function gooseFilter(birds) {
    var geese = ["African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"];
    birds = birds.filter(function (el) {
        return geese.indexOf(el) < 0;
    });
    return birds;
}

console.log('end');

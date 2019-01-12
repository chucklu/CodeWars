'use strict';

console.log('start');
var array = ["1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3"];
array = ["1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4"];
points(array);
//https://www.codewars.com/kata/total-amount-of-points/train/javascript
//https://www.hacksparrow.com/global-variables-in-node-js.html
function points(games) {
    try {
        global.total = 0;
        games.map(calculate);
        console.log(global.total);
        return global.total;
    }
    catch (exception) {
        console.log(exception);
    }
}

function calculate(item) {
    var array = item.split(":");
    var x = array[0];
    var y = array[1];
    var result = 0;
    if (x > y) {
        result = 3;
    } else if (x === y) {
        result = 1;
    }
    global.total += result;
}
console.log('end');


var result = capitalizeWord('word');
console.log(result);
//https://www.codewars.com/kata/capitalization-and-mutability/train/javascript
//https://stackoverflow.com/questions/1026069/how-do-i-make-the-first-letter-of-a-string-uppercase-in-javascript
function capitalizeWord(word) {
    return word[0].toUpperCase() + word.slice(1);
}

//https://www.codewars.com/kata/l1-set-alarm/train/javascript
function setAlarm(employed, vacation) {
    if (!employed) {
        return false;
    } else {
        return !vacation;
    }
}
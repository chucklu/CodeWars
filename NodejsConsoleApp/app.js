'use strict';

console.log('start');

//https://www.codewars.com/kata/students-final-grade/train/javascript
function finalGrade(exam, projects) {
    var result = 0;
    if (exam > 90 || projects > 10) {
        result = 100;
    } else if (exam > 75 && projects >= 5) {
        result = 90;
    } else if (exam > 50 && projects >= 2) {
        result = 75;
    }
    return result;
}

console.log('end');

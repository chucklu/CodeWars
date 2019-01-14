'use strict';

console.log('start');

//https://www.codewars.com/kata/exclamation-marks-series-number-6-remove-n-exclamation-marks-in-the-sentence-from-left-to-right/train/javascript
function remove(s, n) {
    for (var i = 0; i < n; i++) {
        s = s.replace('!', '');
    }
    return s;
}

console.log('end');

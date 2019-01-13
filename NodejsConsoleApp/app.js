'use strict';

console.log('start');

//https://www.codewars.com/kata/exclamation-marks-series-number-6-remove-n-exclamation-marks-in-the-sentence-from-left-to-right/train/javascript
function remove(s, n) {
    var target = [];
    for (var i = 0; i < s.length; i++) {
        if (n > 0) {
            if (s[i] !== '!') {
                target.push(s[i]);
            } else {
                n--;
            }
        } else {
            target.push(s[i]);
        }
    }
    return target.join('');
}

console.log('end');

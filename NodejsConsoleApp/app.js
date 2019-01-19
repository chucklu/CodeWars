'use strict';

console.log('start');

//https://www.codewars.com/kata/do-you-speak-english/train/javascript
function spEng(sentence) {
    var str = sentence.toLowerCase();
    return str.includes('english');
}

console.log('end');

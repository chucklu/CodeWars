'use strict';

console.log('start');

//https://www.codewars.com/kata/hello-name-or-world/train/javascript
function hello(name) {
    var result = '';
    if (typeof name === "undefined") {
        result = 'Hello, World!';
    } else {
        if (name === '') {
            result = 'Hello, World!';
        } else {
            var str = name.toLowerCase();
            str = str.charAt(0).toUpperCase() + str.slice(1);
            result = `Hello, ${str}!`;
        }
    }
    return result;
}

console.log('end');

//Try typeof on all variables you created.
var integer = 1; 
var floatingPoint = 1.1;
var _string = '1';
var _nullable = null;
var notDefined = undefined;
var func = function () {}; //function
var emptyArray = []; //array
var person = {
    name: 'John',
    age: 23
}; // object
var bool = true; //boolean

console.log(typeof integer);//number
console.log(typeof floatingPoint);//number
console.log(typeof _string); // string
console.log(typeof _nullable); //object
console.log(typeof notDefined); //undefined
console.log(typeof func); //function
console.log(typeof emptyArray); //object
console.log(typeof person); //object
console.log(typeof bool); //boolean
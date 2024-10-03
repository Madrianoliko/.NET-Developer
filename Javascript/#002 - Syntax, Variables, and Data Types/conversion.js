

// Creating name variables
let firstName = "David";
let lastName = "David";


// Displaying
console.log(`Hello ${firstName} ${lastName}`);

// Single line

/*
Multi line
*/

/**
 * documentation and configuration comments
 * 
 * 
 * 
 */

// Using typeof

let strValue = "Hi";
console.log(typeof(strValue));
let numValue = 1;
console.log(typeof(numValue));
let boolValue = true;
console.log(typeof(boolValue));

// Join a non- string value witha a string
let age = 41;
// let firstName = "David";
let description = `${firstName} is ${age} years old`
console.log(description);

//Converting a string to a number
let ageString = '41';
let ageNum = Number(ageString);
console.log(typeof(ageNum));
let ageNewNum = new Number(ageString); // "You don't want this" this declare object - not number
console.log(typeof(ageNewNum));

//What about NaN
let ageString2 = 'forty-one'
let ageNum2 = Number(ageString2)
console.log(`Age String 2 : ${ageNum2}`);

let isInvalid = isNaN(ageNum2);
console.log(`Is Invalid: ${isInvalid}`);

//Converting value to a boolean
let num1 = 1;
let num2 = 0;
let bool1 = Boolean(num1);
let bool2 = Boolean(num2);
console.log(`Num1: ${bool1} Num2: ${bool2}`);

let str1 = "Hello";
let bool3 = Boolean(str1);
let val1;
let bool4 = Boolean(val1);
console.log(`Bool3: ${bool3} Bool4: ${bool4}`);

//Converting a boolean to a string
let bool5 = true;
console.log(`Bool 5 : ${bool5}`);

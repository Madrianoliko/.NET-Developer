// JavaScript Object
let employee = {
    firstName: "David",
    lastName: "Tucker",
    birthdate: new Date("January 1, 1982"),
    numYearsEmployment: 7,
    department: "Engineering",
    title: "CTO",
    isActive: true,
    salary: 100000
};

// Convert to JSON String
let jsonValue = JSON.stringify(employee);
console.log(jsonValue);
jsonValue = JSON.stringify(employee, null, 2);
console.log(jsonValue);

//Convert to Value Back to Object

let newEmployee = JSON.parse(jsonValue);
console.log(newEmployee);

// Writing JSON Directly
let jsonString = `{
"firstName": "Elziabet",
"lastName": "Jones"
}`;

let obj = JSON.parse(jsonString);
console.log(obj);

let notJSON = "hello!";
let newObj = JSON.parse(notJSON);
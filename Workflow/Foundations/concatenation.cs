/*
Concatenate a literal string and a variable
*/

string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);


/* 
Concatenate multiple variables and literal strings
*/

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

/* 
Avoiding intermediate variables

Unless you have a good reason to do so, you can (and should) avoid using intermediate variables by performing the concatenation operation as you need it.
*/

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

/* 
String concatenation allows you to combine smaller literal and variable strings into a single string.
Avoid creating intermediate variables if adding them doesn't increase readability.
*/
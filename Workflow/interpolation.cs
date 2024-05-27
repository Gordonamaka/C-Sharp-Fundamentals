/* 
String Interpolation

An interpolation expression is indicated by an opening and closing curly brace symbol { }. You can put any C# expression that returns a value inside the braces. The literal string becomes a template when it's prefixed by the $ character.
*/

string message = greeting + " " + firstName + "!";
// Into this
string message = $"{greeting} {firstName}!";

/*
Use string interpolation to combine a literal string and a variable value
*/
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

/*
Use string interpolation with multiple variables and literal strings 
*/

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

/*
Avoid intermediate variables
*/
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

/* 
Combine verbatim literals and string interpolation

You can use both the verbatim literal prefix symbol @ and the string interpolation $ symbol together.
*/
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// the $ symbol allows you to reference the projectName variable inside the braces, while the @ symbol allows you to use the unescaped \ character.

/* 
String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.
*/

// Challenge First try:
string projectName = "ACME";
string englishMessage = "View English output:\n";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


Console.WriteLine($@"{englishMessage} c:\Exercise\{projectName}\data.txt");

Console.WriteLine($"\n{russianMessage}" + ":" + $@"
  c:\Exercise\{projectName}\data.txt"); 

// Second try
string projectName = "ACME";
string englishMessage = "View English output:";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


Console.WriteLine($"{englishMessage}" + $@"
  c:\Exercise\{projectName}\data.txt");

Console.WriteLine($"\n{russianMessage}" + ":" + $@"
  c:\Exercise\{projectName}\data.txt");

// Lesson Solution
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
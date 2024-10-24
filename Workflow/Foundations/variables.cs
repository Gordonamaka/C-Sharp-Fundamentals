/* 
To create a new variable, you must first declare the data type of the variable, and then give it a name (C# uses camel case).

string firstName;

Other Variable examples:

char userOption;

int gameScore;

decimal particlesPerMillion;

float particlesPerBillion;

bool processedCustomer;

Variable Declaration
string firstName;
firstName = "Tasha";
Console.WriteLine(firstName);

** Variables seem to have get/set properties like let in javascript:

You must assign (set) a value to a variable before you can retrieve (get) a value from a variable.
You can initialize a variable by assigning a value to the variable at the point of declaration.
Assignment happens from right to left.
You use a single equals character as the assignment operator.
To retrieve the value from the variable, you merely use the variable's name.

VAR

An implicitly typed local variable is created by using the var keyword followed by a variable initialization.
var message = "Hello world";
Console.WriteLine(message);

The var keyword tells the C# compiler that the data type is implied by the assigned value. After the type is implied, the variable acts the same as if the actual data type had been used to declare it. 
**The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context.**

Because the variable message is immediately set to the string value "Hello World!", the C# compiler understands the intent and treats every instance of message as an instance of type string.

The type is locked in at the time of declaration and therefore will never be able to hold values of a different data type. (no implicit conversion) : Implicitly-typed variables must be initialized.

Using data types allow the data types to be used as a getter/setter, var does not.

Variable concatenation works the same way (example below):
*/

var bonjour = "Hello, ";
var name = "Bob! ";
var sentence = "You have ";
var message = " messages in your inbox. ";
var temperature = "The temperature is ";
var end = " celsius.";
var three = 3;
var thirtyPoint = 34.4;

Console.Write(bonjour + name + sentence + three + message + temperature + thirtyPoint + end);

// Output: Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.

// Alternative:
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");


/* 

Variable Name Rules 

Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.

Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start a variable name is typically reserved for private instance fields.

Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.

Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.

*/
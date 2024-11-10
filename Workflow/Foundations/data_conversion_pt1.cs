/* 
Perform addition with implicit data conversion
*/
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

/* 
Mix data types to force implicit type conversions
*/
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");


/* 
More advanced
Instead of adding the int variable widgetsSold to the literal int 7, the compiler treats everything as a string and concatenates it all together.
*/
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

/*
Add parentheses to clarify your intention to the compiler
*/
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");


/* 
You can perform mathematical-like addition operations on numbers.

Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.

When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to concatenate the string representation of a number for presentation purposes.

Use parentheses to define an order of operations to explicitly tell the compiler that you want to perform certain operations before other operations.
*/
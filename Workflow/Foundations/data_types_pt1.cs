/* 
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits

When you use single quotation marks, the C# compiler expects a single character (char vs string). 

Just like the string data type, you use char whenever you have a single alphanumeric character for presentation (not calculation).

INT
An int literal requires no other operators like the string or char.
Console.WriteLine(123);

FLOAT  - f suffix
To create a float literal, append the letter F after the number. In this context, the F is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of float type. You can use either a lower-case f or upper-case F as the literal suffix for a float.
Console.WriteLine(0.25F);

DOUBLE
To create a double literal, just enter a decimal number. The compiler defaults to a double literal when a decimal number is entered without a literal suffix.
Console.WriteLine(2.625);

DECIMAL - m suffix
To create a decimal literal, append the letter m after the number. In this context, the m is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of decimal type. You can use either a lower-case m or upper-case M as the literal suffix for a decimal.
Console.WriteLine(12.39816m);

BOOL
The bool literals represent the idea of truth and falsehood. You'll use bool values extensively when you start to add decision logic to your applications. You'll evaluate expressions to see whether the expression is true or false.

If you need to perform a mathematical operation on numeric values, you should use an int or decimal. If you have data that is used for presentation or text manipulation, you should use a string or char data type.
*/


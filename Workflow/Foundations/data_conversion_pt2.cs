/* If you need to change a value from the original data type to a new data type and the change could produce an exception at run time, you must perform a data conversion.

To perform data conversion, you can use one of several techniques:

Use a helper method on the data type
Use a helper method on the variable
Use the Convert class' methods */

// Widening Conversion

/* The term widening conversion means that you're attempting to convert a value from a data type that could hold less information to a data type that can hold more information. In this case, a value stored in a variable of type int converted to a variable of type decimal, doesn't lose information.

When you know you're performing a widening conversion, you can rely on implicit conversion. The compiler handles implicit conversions. */
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

// Casting

/* To perform a cast, you use the casting operator () to surround a data type, then place it next to the variable you want to convert (example: (int)myDecimal). You perform an explicit conversion to the defined cast data type (int).

The variable myDecimal holds a value that has precision after the decimal point. By adding the casting instruction (int), you're telling the C# compiler that you understand it's possible you'll lose that precision, and in this situation, it's fine. You're telling the compiler that you're performing an intentional conversion, an explicit conversion. */
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

// Narrowing Conversion

/* The term narrowing conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information.

You can observe from the output that casting a decimal into a float is a narrowing conversion because you're losing precision. */
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

// String Conversion Method

/* On most primitives, it performs a widening conversion. */
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Parse Conversion Method

/* Most of the numeric data types have a Parse() method, which converts a string into the given data type. In this case, you use the Parse() method to convert two strings into int values, then add them together. 

If you receive a value that can't be converted use TryParse() */
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

// Convert Conversion Method

/* The Convert class has many helper methods to convert a value from one type into another. In the following code example, you convert a couple of strings into values of type int. 

Why is the method name ToInt32()? Why not ToInt()? System.Int32 is the name of the underlying data type in the .NET Class Library that the C# programming language maps to the keyword int. Because the Convert class is also part of the .NET Class Library, it is called by its full name, not its C# name. By defining data types as part of the .NET Class Library, multiple .NET languages like Visual Basic, F#, IronPython, and others can share the same data types and the same classes in the .NET Class Library.*/
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

/* You used the Convert.ToInt32() method with a string here, but you should probably use TryParse() when possible.

So, when should you use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect. */

// Compare casting and converting a decimal into an int

/* The following example demonstrates what happens when you attempt to cast a decimal into an int (a narrowing conversion) versus using the Convert.ToInt32() method to convert the same decimal into an int. */
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

// ** IMPORTANT - Casting truncates and converting rounds

/* When you're casting int value = (int)1.5m;, the value of the float is truncated so the result is 1, meaning the value after the decimal is ignored completely. You could change the literal float to 1.999m and the result of casting would be the same.

When you're converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. If you changed the literal value to 1.499m, it would be rounded down to 1. */
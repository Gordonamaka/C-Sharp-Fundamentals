/* 
Perform basic math operations
+ is the addition operator
- is the subtraction operator
* is the multiplication operator
/ is the division operator
% is the modulus operator
*/
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

/* 
Add code to perform division using literal decimal data
For this to work, the quotient (left of the assignment operator) must be of type decimal and at least one of numbers being divided must also be of type decimal (both numbers can also be a decimal type).
*/
decimal decimalQuotient = 7.0m / 5;
decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

/* 
Add code to cast results of integer division

Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type.

To cast int to decimal, you add the cast operator before the value. You use the name of the data type surrounded by parentheses in front of the value to cast it. In this case, you would add (decimal) before the variables first and second.
*/
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

/* 
Write code to determine the remainder after integer division
*/
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

/* 
Order of operations

In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:

Parentheses (whatever is inside the parenthesis is performed first)
Exponents
Multiplication and Division (from left to right)
Addition and Subtraction (from left to right)

Operators like +=, -=, *=, ++, and -- are known as compound assignment operators because they compound some operation in addition to assigning the result to the variable. The += operator is specifically termed the addition assignment operator.

If you use the operator before the value as in ++value, then the increment will happen before the value is retrieved. Likewise, value++ will increment the value after the value has been retrieved.
*/
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Challenge - To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).
int fahrenheit = 94;
decimal fiveNinths = 5.0m / 9.0m; // Don't forget m's for decimals & (decimal is unnecessary)
Console.WriteLine($"The temperature is {((decimal)fahrenheit - 32) * (fiveNinths)} Celsius"); // (decimal is unneccesary)
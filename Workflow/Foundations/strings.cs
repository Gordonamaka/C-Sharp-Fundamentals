/* 
Character escape sequences

In C#, the escape character sequence begins with a backslash \ followed by the character you're escaping. 
For example, the \n sequence will add a new line, and a \t sequence will add a tab.

Console.WriteLine("c:\source\repos"); Won't work because backlashes are reserved for escape sequences.
The problem is the sequence \s. The \r doesn't produce an error because it's a valid escape sequence for a carriage return. However, you don't want to use a carriage return in this context.

To solve this problem, you use the \\ to display a single backslash.
Console.WriteLine("c:\\source\\repos");
*/
--------------------------------------------------------------------------
/* 
Format output using character escape sequences - ex:
*/
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
--------------------------------------------------------------------------
/* 
Verbatim String Literal

A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.

In this instance, you don't have to use the \\ for a character escape sequence.

Example:
*/
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
--------------------------------------------------------------------------
/*
Format output using verbatim string literals
*/
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");
--------------------------------------------------------------------------
/*
Unicode escape characters

You can also add encoded characters in literal strings using the \u escape sequence, then a four-character code representing some character in Unicode (UTF-16).
*/
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
--------------------------------------------------------------------------
/* 
Format output using unicode escape characters
*/
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


/* -- RECAP --
Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
Unicode characters may not print correctly depending on the application.
*/

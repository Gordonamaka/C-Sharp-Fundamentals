// You use the IndexOf() method to locate the position of one or more characters string inside a larger string. You use the Substring() method to return the part of the larger string that follows the character positions you specify. You can also overload substring() method to set the length of character positions you specify. 
string message = "Find what is (inside the parentheses)";

// IndexOf() returns -1 if it can't find a match.
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// For HTML Elements
string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// Avoid magic values
string message = "What is the value <span>between the tags</span>?";

// Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// LastIndexOf - The method .LastIndexOf() returns the index position of the last occurrence of a character or string within a given string.
string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// Retrieve all Instances of substrings inside parentheses
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
  int openingPosition = message.IndexOf('(');
  // The IndexOf() method returns -1 if it can't find the input parameter in the string. You merely check for the value -1 and break out of the loop.
  if (openingPosition == -1) break;

  openingPosition += 1;
  int closingPosition = message.IndexOf(')');
  int length = closingPosition - openingPosition;
  Console.WriteLine(message.Substring(openingPosition, length));

  // Note the overload of the Substring to return only the remaining 
  // unprocessed message:
  message = message.Substring(closingPosition + 1);
}
/* When you use Substring() without specifying a length input parameter, it will return every character after the starting position you specify. With the string being processed, message = "(What if) there are (more than) one (set of parentheses)?", there's an advantage to removing the first set of parentheses (What if) from the value of message. What remains is then processed in the next iteration of the while loop. */

// IndexOfAny - Reports the index of the first occurrence of any character in a supplied array of characters. The method returns -1 if all characters in the array of characters are not found.
string message = "Hello, world!";
char[] charsToFind = ['a', 'e', 'i'];

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

//
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

// Loop to find letters within symbols
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = ['[', '{', '('];

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
  int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

  if (openingPosition == -1) break;

  string currentSymbol = message.Substring(openingPosition, 1);

  // Now  find the matching closing symbol
  char matchingSymbol = ' ';

  switch (currentSymbol)
  {
    case "[":
      matchingSymbol = ']';
      break;
    case "{":
      matchingSymbol = '}';
      break;
    case "(":
      matchingSymbol = ')';
      break;
  }

  // To find the closingPosition, use an overload of the IndexOf method to specify 
  // that the search for the matchingSymbol should start at the openingPosition in the string. 

  openingPosition += 1;
  closingPosition = message.IndexOf(matchingSymbol, openingPosition);

  // Finally, use the techniques you've already learned to display the sub-string:

  int length = closingPosition - openingPosition;
  Console.WriteLine(message.Substring(openingPosition, length));
}

// Remove - use Remove() when there's a standard and consistent position of the characters you want to remove from the string.
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
// The Remove() method works similarly to the Substring() method. You supply a starting position and the length to remove those characters from the string.

// Replace -
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

// Extract, replace, and remove data from an input string

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
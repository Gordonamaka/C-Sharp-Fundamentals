/* 
 A code block that influences the exit criteria is a primary reason to select a do-while or while statements rather than one of the other iteration statements. Both the foreach and for rely on factors that are external to the code block to determine the number of code block iterations.
*/

Random random = new Random();
int current = random.Next(1, 11);
// The do-while iterates through a code block at least one time. Code execution exits the iteration loop once the while expression at the end of the code block evaluates to true.
do
{
  current = random.Next(1, 11);

  // Skip every iteration equal to or greater than 8
  if (current >= 8) continue;
  // The continue keyword to step immediately to the Boolean expression.

  Console.WriteLine(current);
} while (current != 7);

/* 
If current is initialized to a value greater than or equal to 3, then the Boolean expression will return true, and the flow of execution will enter the code block. Inside the code block, the first thing that we do is write the value of current to the console. Next, still inside the code block, we update the value of current with a new random value. At this point, control goes back to the top of the while statement where the Boolean expression is evaluated. This process continues until the Boolean expression returns false and the flow of execution breaks from the code block.

If current is initialized (at the top of our code) to a value less than 3, then the Boolean expression will return false, and the code block will never execute.
*/

while (current >= 3)
{
  Console.WriteLine(current);
  current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

// Iterations pt.2

/*  Our iterations so far:
- The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.

- The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.

- The do-while statement: conditionally executes its body one or more times.

- The while statement: conditionally executes its body zero or more times.
*/

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
  readResult = Console.ReadLine();
  if (readResult != null)
  {
    if (readResult.Length >= 3)
    {
      validEntry = true;
    }
    else
    {
      Console.WriteLine("Your input is invalid, please try again.");
    }
  }
} while (validEntry == false);

// int.TryParse() method can be used to convert a string value to an integer.

// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

// Returns boolean value
validNumber = int.TryParse(readResult, out numericValue);


// Coding Exercise 1 do-while integer conversion
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{

  readResult = Console.ReadLine();

  // Set value
  if (readResult != null)
  {
    valueEntered = readResult;
  }

  // Set conversion
  validNumber = int.TryParse(valueEntered, out numValue);

  // Check
  if (validNumber == true)
  {
    // Inclusive OR
    if (numValue <= 5 || numValue >= 10)
    {
      validNumber = false; // Stop clause
      Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
    }
  }
  else
  {
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
  }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();

// Excerise 2 - My solution
string? readResult;
string inputValue = "";
bool validEntry = false;


Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
do
{
  readResult = Console.ReadLine();
  if (readResult != null)
  {

    inputValue = readResult.Trim().ToLower();

    if (inputValue == "user")
    {
      validEntry = true;
      Console.WriteLine("Your input value (User) has been accepted");
    }
    else if (inputValue == "manager")
    {
      validEntry = true;
      Console.WriteLine("Your input value (Manager) has been accepted");
    }
    else if (inputValue == "Administrator")
    {
      validEntry = true;
      Console.WriteLine("Your input value (Administrator) has been accepted");
    }
    else
    {
      Console.WriteLine($"The role name that you entered, {inputValue} is not valid. Enter your role name (Administrator, Manager, or User):");
    }
  }

} while (validEntry == false);


// Coding Solution Three - Their solution
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
  myString = myStrings[i];
  periodLocation = myString.IndexOf(".");

  string mySentence;

  // extract sentences from each string and display them one at a time
  while (periodLocation != -1)
  {

    // first sentence is the string value to the left of the period location
    mySentence = myString.Remove(periodLocation);

    // the remainder of myString is the string value to the right of the location
    myString = myString.Substring(periodLocation + 1);

    // remove any leading white-space from myString
    myString = myString.TrimStart();

    // update the comma location and increment the counter
    periodLocation = myString.IndexOf(".");

    Console.WriteLine(mySentence);
  }

  mySentence = myString.Trim();
  Console.WriteLine(mySentence);
}
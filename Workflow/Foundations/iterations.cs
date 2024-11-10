/* For Statements 
The for statement includes the following six parts:

a) The for keyword.

b) A set of parentheses that defines the conditions of for iteration. The parentheses contain three distinct parts, separated by the end of statement operator, a semi-colon.

c) The first part defines and initializes the iterator variable. In this example: int i = 0. This section is referred to as the initializer.

d) The second part defines the completion condition. In this example: i < 10. In other words, the runtime will continue to iterate over the code in the code block below the for statement while i is less than 10. When i becomes equal to 10, the runtime stops executing the for statement's code block. The docs refer to this section as the condition.

e) The third part defines the action to take after each iteration. In this case, after each iteration, i++ will increment the value of i by 1. The docs refer to this section as the iterator.

f) Finally, the code block. The code block contains the code that will be executed for each iteration. Notice that the value of i is referenced inside of the code block. The docs refer to this section as the body.
*/

// Incrementor
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}

// Decrementor
for (int i = 10; i >= 0; i--)
{
  Console.WriteLine(i);
}

// Increment by 3
for (int i = 0; i < 10; i += 3)
{
  Console.WriteLine(i);
}

// Iterator with Break Statement
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
  if (i == 7) break;
}

// String Iterator
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// Change/Replace Iterator
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

// FizzBuzz Iterator
for (int i = 1; i < 101; i++)
{
  if ((i % 3 == 0) && (i % 5 == 0))
    Console.WriteLine($"{i} - FizzBuzz");
  else if (i % 3 == 0)
    Console.WriteLine($"{i} - Fizz");
  else if (i % 5 == 0)
    Console.WriteLine($"{i} - Buzz");
  else
    Console.WriteLine($"{i}");
}

/* The %, the mod operator, allows you to determine if 3 or 5 divide into another number without a remainder.

And the && operator ensures that a number can be divided into both 3 and 5 for the FizzBuzz condition. */
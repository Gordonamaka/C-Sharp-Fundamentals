/* 
Summary:
- Clear items in an array, learning the elements are set to null, using the Array.Clear()method.
- Resize an array to add and remove elements using the Array.Resize() method.
- Convert a string into an array using String.Split() specifying a string separator character to produce a value in the returned array.
- Combine all of the elements of an array into a single string using the String.Join() method.
*/


string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

/* When you use Array.Clear(), the elements that were cleared no longer reference a string in memory. In fact, the element points to nothing at all. Pointing to nothing is an important concept that can be difficult to grasp at first. */
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

/* If you focus on the line of output After: , you might think that the value stored in pallets[0] is an empty string. However, the C# Compiler implicitly converts the null value to an empty string for presentation. */

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}


// Resize

string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

// Removes the last three elements

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

// If the Array.Resize() method doesn't remove empty elements from an array, is there another helper method that does the job automatically? No. The best way to empty elements from an array would be to count the number of non-null elements by iterating through each item and increment a variable (a counter). Next, you would create a second array that is the size of the counter variable. Finally, you would loop through each element in the original array and copy non-null values into the new array. 

// Null isn't the same as an empty string or the value zero.

// String to Char Array Method - Strings are immutatable so they must be changed into an array before reversing.
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new(valueArray);
Console.WriteLine(result);

// Join Method

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

// Split
string[] items = result.Split(',');
foreach (string item in items)
{
  Console.WriteLine(item);
}


// Reverse each word in a message
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
  char[] letters = message[i].ToCharArray();
  Array.Reverse(letters);
  newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);


// To parse a string of orders, sort the orders and tag possible errors
// My Solution
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(",");
Array.Sort(orderArray);

for (int i = 0; i < orderArray.Length; i++)
{
  if (orderArray[i].Length > 4 || orderArray[i].Length < 4)
  {
    orderArray[i] = $"{orderArray[i]} \t - Error";
  }
  Console.WriteLine(orderArray[i]);
}

// Their Solution
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
  if (item.Length == 4)
  {
    Console.WriteLine(item);
  }
  else
  {
    Console.WriteLine(item + "\t- Error");
  }
}
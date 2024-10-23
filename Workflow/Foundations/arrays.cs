/* 
The first set of square brackets [] merely tells the compiler that the variable named fraudulentOrderIDs is an array, but the second set of square brackets [3] indicates the number of elements that the array can hold.
*/
// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


// ForEach Method
string[] names = ["Rowena", "Robin", "Bao"];


foreach (string name in names)
{
  Console.WriteLine(name);
}

// int exercise 
int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{ // items is only a temporary variable
  sum += items;
  bin++; // each time the code block is executed
  Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");


// OrderList Exercise
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
      Console.WriteLine(orderID);
    }
}
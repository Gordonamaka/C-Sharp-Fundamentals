// Random vs var (variable instantiation)
// Instantiate random number generator using system-supplied value as seed.
// var rand = new Random();

Random dice = new Random();
// Random dice = new(); new dotnet doesn't require random stated twice...
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

/* 
Stateful versus stateless methods
In software development projects, the term state is used to describe the condition of the execution environment at a specific moment in time. As your code executes line by line, values are stored in variables. At any moment during execution, the current state of the application is the collection of all values stored in memory.

Some methods don't rely on the current state of the application to work properly. In other words, stateless methods are implemented so that they can work without referencing or changing any values already stored in memory. Stateless methods are also known as static methods.

For example, the Console.WriteLine() method doesn't rely on any values stored in memory. It performs its function and finishes without impacting the state of the application in any way.

Other methods, however, must have access to the state of the application to work properly. In other words, stateful methods are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed. Or they modify the state of the application by updating values or storing new values in memory. They're also known as instance methods.

Stateful (instance) methods keep track of their state in fields, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state.

A single class can support both stateful and stateless methods. However, when you need to call stateful methods, you must first create an instance of the class so that the method can access state.

An instance of a class is called an object. To create a new instance of a class, you use the new operator.

The new operator does several important things:

It first requests an address in the computer's memory large enough to store a new object based on the Random class.
It creates the new object, and stores it at the memory address.
It returns the memory address so that it can be saved in the dice object.

To use the Random.Next() method, however, you don't have to understand how it works. The important thing to know is that some methods require you to create an instance of a class before you call them, while others do not.
*/
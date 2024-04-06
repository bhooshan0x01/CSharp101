//---------------- Variables & data types

// every variable must have a type
int x = 6; //integer
double y = 4.5; //floating point number
string name = "Jack"; //String 
bool is_integer = false; //boolean type
char grade = "A"; //character 
DateTime today = DateTime.Now; //DateTime is builtin C# structure for date and time

//---------------- Control statements / if statements
if(x > 5)
{
    Console.WriteLine("greater than 5");
}
else if(x == 5)
{
    Console.WriteLine("Equal to 5");
}
else
{
    Console.WriteLine("Smaller");
}

// another control statement

string weather = "sunny";

if(weather == "rainy")
{
    Console.WriteLine("Take an umbrella");
}
else if(weather == "sunny")
{
    Console.WriteLine("apply sunscreen");
}
else 
{
    Console.WriteLine("Check the weather forecast");
}

//---------------- Loops 

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

//i++ this is the post loop action or increment part
// after each loop iteration, whatever is written here will be executed.
// the ++ is a shorthand operation in C# that means 
// increment the value by 1, so i++ is equivalent to i = i + 1;

// Looping backwards

for(int i = 5; i > 0; i--) //i-- means de increment by 1 
{
    Console.WriteLine(i);
}

string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri"};
//foreach when want to iterate over each item in a collection without using an index.
foreach(string day in days)
{
    Console.WriteLine(day);
}

//print every 2nd numbers
// i+=2 means increment i by 2.
for(int i=0; i<= 10; i+=2)
{
    Console.WriteLine(i);
}

//---------------- While loops

int i = 0;
while(i < 5)
{
    Console.WriteLine(i);
    i++;
    //i++ means add 1 to i
}

//---------------- Functions or Methods

public string Greet(string name)
{
    return "Hello, " + name;
}

public static int Add(int a, int b)
{
    reutrn a + b;
}

//---------------- List & Arrays 

int[] numbers = {1, 2, 3, 4, 5};

//arrays are used to store multiple values in a single variable
List<string> fruits = new List<string> {"apple", "banana", "kiwi", "cherry"};
fruits.Add("dragonfruit");

//---------------- Switch statements
//its a way to make multiple comparisions in a more structured manner 
//than a bunch of else ifs
enum Day {Monday, Tuesday, Wednesday, Thursday, Friday}

Day today = Day.Friday;

switch(today)
{
    case Day.Monday:
        Console.WriteLine("Start of the work week");
        break;
    case Day.Tuesday:
        Console.WriteLine("It is tuesday");
        break;
    default:
        Console.WriteLine("It's some other day.");
        break;
}

//-------- Function with overloading & passing by reference 

//public keyword denotes the access level of the method.
//static means you dont need to instantiate the class to use
//this method. void/string/int before function name denotes the return type
// of the method. Inside the paranthesis, you define the parameters.

//Show with same method name but different parameters is an example of
//method overloading 

public static void Show(int a)
{
    Console.WriteLine($"Integer: {a}");
}

public static void Show(string a)
{
    Console.WriteLine($"String: {a}");
}

// Different methods can have the same name but different parameters

public static void Main(string[] args)
{
    Show(2);
    Show("Monday");
}

//-------- Passing parameters by reference 

//by default, parameters are passed by value in c#.
//however, you can pass them by reference using the ref keyword,
//meaning changes to the parameter within the method will affect
//its value outside the method.

public static void AddTen(ref int number)
{
    number += 10;
}

public static void Main(string[] args)
{
    int value = 20;
    AddTen(ref value);
    Console.WriteLine(value); //outputs 30
}
//-------- Classes, Objects and Inheritance

//classes allow you to group properties and methods

public class Bird
{
    public string Name { get; set; }
    //{ get; set; } is an auto-implemented property,
    //a shorthand for defining a property in C#

    public Bird(string name)
    {
        this.Name = name;
    }

    public string Sing()
    {
        return $"{Name} sings!";
    }
}

//Here, we've defined a class named Bird with a property Name and 
//a method Sing. public denotes that the class, property, and method 
//can be accessed from outside the class.

public static void Main(string[] args)
{
    Bird myBird = new Bird("Queeny");
    Console.writeLine(myBird.Sing());
}

//Inheritance

public class Sparrow : Bird
{
    public Sparrow(string name) : base(name) {}

    public string Fly()
    {
        reutrn $"{Name} flies high!";
    }
}

//here Sparrow inherits from Bird and can both Sing(inherited)
//and fly (unique to Sparrow).


//-------------- Interfaces and Polymorphism
//interface is a blueprint of a class.
// it's like a class but has no implementation.
// the only thing it contains are declarations of events, indexeres, methods 
// and properties.
//any class or struct that implements the interface must also implement
// the members of the interface.

public interface IFlyable
{
    void Fly();
}

//implementing interfaces: 
//once an interface is defined, any classes or struct can implement it.
//once they do, they have to provide an implementation for all the members of the interface.

public class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("The bird can fly.");
    }
}

public class Airplane : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("The airplane can fly.");
    }
}

//Polymorphism is a concept where an object can take many forms.
//the most common use of polymorphism is when a parent class references is used to refer to a child class object

IFlyable flyingObject1 = new Bird();
IFlyable flyingObject2 = new Airplane();

flyingObject1.Fly(); // outputs: The bird can fly.
flyingObject2.Fly(); // outputs: The airplane can fly.

//------------------ TRY & CATCH Block

try
{
    int[] arr = new int[5];
    arr[10] = 100; // this will throw an exception as the index is out of bounds.
}
catch (System.Exception ex) // this brings in real error
{
    
    Console.WriteLine(ex.Message); //outputs the index was outside the bounds.
}

//you can have multiple catch block too

try
{
    //some code that errors out
}
catch(IndexOutOfRangeExceptions ex)
{
    // handle index out of range exceptions
}
catch(ArgumentNullException ex)
{
    // handle null arguments
}
catch(Exception ex)
{
    // General catch block for all other exceptions
}

//Finally block
//it can be added after the catch blocks.
//the code inside the 'finally' block always executes regardess of whether
//an exception was thrown or not.

try
{
    //some code that may throw exceptions
}
catch(Exception ex)
{
    // Handle exception
}
finally
{
    //this code always runs
}

// you can manually throw exceptions with throw
if(string.IsNullOrEmpty(name))
{
    throw new ArgumentNullException("Name cannot be nnull or empty.");
}


//---------------- Collections 
//Collections are group of objects 
// the System.Collections and System.Collections.Generic namespaces contain
//interfaces and classes that define various collections of objects
//such as lists, queues, bit arrays, hash tables and dictionaries.

//---Array 
//arrays are fixed sized collections and cant be changes
int[] numbers = new int[5];
numbers[0] = 10;
numbers[1] = 20;

//---Lists
//List<T> is a dynamic array, meaning it can grow in size as needed.
//it's part of System.Collections.Generic namespace
List<int> numberList = new List<int>();
numberList.Add(1);
numberList.Add(2);
numberList.Add(3);

//---Dictionaries
//Dictionary<TKey, TValue> is a collection of key-value pairs. It's also part of the 
//System.Collections.Generic namespace

Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
ageDictionary["Alice"] = 25;
ageDictionary["Bob"] = 30;

//Queues 
//Queue<T> represents a first in first out (FIFO) collection

Queue<string> nameQueue = new Queue<string>();
nameQueue.Enqueue("Alice");
nameQueue.Enqueue("Bob");
string firstInLine = nameQueue.Dequeue(); //Alice

//Stack
//Stack<T> represents a last in first out (LIFO) collection.

Stack<string> nameStack = new Stack<string>();
nameStack.Push("Alice");
nameStack.Push("Bob");
string lastAdded = nameStack.Pop(); //Bob

//--------- LINQ (Language integrated query)
// querying collections - consider u have a list of integers and want to fetch numbers greater than 5

List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9};
var query = from num in numbers 
            where num > 5
            select num;
foreach(var num in query)
{
    Console.WriteLine(num);
}

//method based queries VS query expressions 
//above example used a query expression. LINQ also provides method-based queries.
//which can sometimes be more concise.

var methodQuery = numbers.Where(n => n > 5);
foreach(var num in methodQuery)
{
    Console.WriteLine(num);
} 

//example linq with strings
string[] names = {"Alice", "Bob", "Charlie", "David"};
var shortNames = from name in names
                where name.Length <= 4
                select name;

foreach(var name in shortNames)
{
    Console.WriteLine(name); //outputs Bob
}

// Key Takeaways:
//Consistency: with LINQ you have a consistent way of querying different data sources.
//Intellisense and Compile-Time Checking: as LINQ is integrated into C# you benefit from 
//compile time checking and Intellisense in Visual Studio
//Exrensibility: LINQ is extensible so you can create custom providers to work with your own data source.


//------ File Handling 
//System.IO namespace
//Reading from files:
//you can use the 'File' class to read text from a file.
//the File.ReadAllText method reads the entire file as a single string.
//while File.ReadAllLines reads the file line by line into a string array.

using System;
using System.IO;

//reading the entire file as a single string
string content = File.ReadAllText("path_to_file.txt");
Console.WriteLine(content);

//Reading the file line by line
string[] lines = File.ReadAllLines("path_to_file.txt"); 
foreach(string line in lines)
{
    Console.WriteLine(line);
}

//writing a string to a file
File.WriteAlltext("path_to_file.txt", "Hello, Worlds!");

//writing an array of strings to a file
string[] contents = {"Hello", "World", "from", "C#"};
File.WriteAllLines("path_to_file.txt", contents);

//File I/O Exceptions
try
{
    string content = File.ReadAllText("non_existent_file.txt");
    Console.WriteLine(content);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File not found: " + ex.Message);
}
catch (IOException ex)
{
    Console.WriteLine("An I/O error occurred: " + ex.Message);
}

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


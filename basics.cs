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
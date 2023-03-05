/* INTRODUCTION:

Hello, and welcome to my C# basics tutorial. I will demonstrate the
applications and syntaxes behind the C# programming language through
the use of variables, expressions, conditionals, loops, functions,
classes, and structures. */

//while its traditional for C# programs to utilize command lines that
//write like "System.<component>.<command>", having this following line
//at the beginning will bypass this tedium, since it allows the program
//to recognize all applicable spots and fill in the blanks itself
using System;

//it is also traditional to have a namespace declaration at the beginning
//of your C# code. Scriptcs also bypasses this need, but I believe it is
//still worth having here.

//namespace module04

/* VARIABLES AND EXPRESSIONS:

Just like with other languages, variables denote any value or piece of
data that is saved under a name, and usually falls under certain types,
such as int (whole numbers), string (collection of characters), float
(fractional or decimal numbers) and bool (binary values such as true/
fasle, etc.), just to name a few. Expessions denote any usage or
manipulation of variables within the syntax. */
Console.WriteLine("VARIABLES AND EXPRESSIONS: \n");

string word = "Bruh";
Console.WriteLine("String Variable: " + word);

//like in C++, different variable types are different sizes, and require
//different levels of memory. Float can only store decimals up to 7
//digits long because its only 4 bytes in size. Double, however, can
//store decimals up to 15 digits long, since its 8 bytes large.

//notice the capital F at the end of the value. Decimal values will save
//as double variables by default. This is necessary for the conversion.
float smallDecimal = 3.1415926F;
Console.WriteLine("Float variable: " + smallDecimal);

double largeDecimal = 3.141592653589793;
Console.WriteLine("Double Float:   " + largeDecimal);

//declaring multiple variables of the same type with one line
int a, b, c, sum;
a = 6;
b = 7;
c = 8;
sum = a + b + c;
Console.WriteLine("Starting sum:                 " + sum);
Console.WriteLine("Sum with 9 added to the end: " + sum + 9);
Console.WriteLine("Sum plus nine:                " + (sum + 9));


/* CONDITIONALS AND LOOPS:

Just like in other languages, conditionals refer to specified conditions
that must be met in order for functions to trigger. Loops are certain
conditionals that will recall over and over again so long as the specified
condition is met. */
Console.WriteLine("\nCONDITIONALS AND LOOPS: \n");

//the variable "input" has no value yet, so the while loop will trigger.
string input;
bool conditional;

//notice the use of "&&". This is how C# renders the "and" conditional,
//usually written out as the english word in python and other languages
while (input != "y" && input != "n")
{
    Console.Write("Type 'y' for true, or 'n' for false: ");
    input = Console.ReadLine();
    if (input == "y")
//unlike Python, where True and False have to be capitalized when used
//as boolean variables, C# requires that they be lowercase    
        conditional = true;
    else if (input == "n")
        conditional = false;
    else
        Console.WriteLine("Error. Please type 'y' or 'n' only.");
}
if (conditional == true)
    Console.WriteLine("Boolean condition met.");
else if (conditional == false)
    Console.WriteLine("Boolean condition not met.");
else
    Console.WriteLine("Error");

/*
CLASSES AND FUNCTIONS:

These two aspects work a bit differently in C#. For the most part, they
are relatively the same concepts from other languages. Functions are
defined codespaces meant to perform a specific task. That function can
then be called again and again in different parts of the program, but with
different or new parameters to manipulate each time. Classes can build and
define different objects for other parts of the code to pull from.
*/
Console.WriteLine("\nCLASSES AND FUNCTIONS:\n");

//classes and functions are also required to be called before their
//respective declarations. Afterwards won't work. Setting a class will
//also alter the namespace following it, so anything outside of classes,
//functions, or structures will not be recognized. Therefore, classes are
//best placed at the end of the program.
Console.WriteLine("Average of 5 and 7:    " + average(5, 7));
Console.WriteLine("Average of 50 and 100: " + average(50, 100));
Console.WriteLine("Average of 3 and 4:    " + average(3, 4) + "\n");
float average(int num1, int num2)
{
    float avg = (num1 + num2) / 2F;
    return avg;
}

ClassTutorial info = new ClassTutorial();
//in C#, you cannot use any print statements to output anything from 
//within functions or classes. This must be done outside of the class or
//function in order to see the output in the terminal.
Console.WriteLine("Public Info:  " + info.declassified);
//any variables within classes are known as fields, and must be called
//alongside the class.
Console.WriteLine("Private Info: " + info.getInfo);

/* STRUCTURES:

Similar to Classes, Structures are also capable of storing several data
types and variables under one name. Unlike Classes, the objects found in
Structures can be used to then create multiple variables outside of the
Structure, that can then have further data assigned to them. */
Console.WriteLine("\nSTRUCTURES AND UNIONS:\n");

Computers PC1;
Computers PC2;

PC1.model = "HP";
PC1.developer = "Microsoft";
PC1.color = "black";
PC1.operatingSys = "Windows";
Console.WriteLine("Our first PC is a " + PC1.color + " " + PC1.model + " developed by " + PC1.developer + " and running on " + PC1.operatingSys);

PC2.model = "Mac";
PC2.developer = "Apple";
PC2.color = "white";
PC2.operatingSys = "iOS";
Console.WriteLine("Our Second PC is a " + PC2.color + " " + PC2.model + " developed by " + PC2.developer + " and running on " + PC2.operatingSys);

//here we have the structure that holds the base info for the previous
//lines to pull from.
struct Computers
{
    public string model;
    public string developer;
    public string color;
    public string operatingSys;
}

//here we have the class that line 115 will pull from
class ClassTutorial
{
//fields given the name of "public" or "private" are known as properties,
//and these properties determine the fields' accessibility.
    public string declassified = "aaKakariko";
    private string classified = "Joshua Capron";
//trying to use this private variable will cause the program to error out
//so I have created another function below that will allow us to pull the
//info. This is called above, instead of the private variable directly.
    public string getInfo
    {
        get {return classified;}
        set {classified = value;}
    }
}
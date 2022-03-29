// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Making a string
// string message1 = "Hello to this new string!";

// //Consoling it out
// Console.WriteLine(message1);

// // // Strings are immutible:
// // string s1 = "Hello ";
// // string s2 = s1;
// // s1 += "World";

// // System.Console.WriteLine(s2);
// // //Output: Hello

// byte b1 = 255;
// // byte b2 = 256;

// short s1 = 32000;

// // Console.WriteLine(Byte.MaxValue);//255
// // Console.WriteLine(Byte.MinValue);//0
// // Console.WriteLine(SByte.MaxValue);//127
// // Console.WriteLine(SByte.MinValue);//-128
// Console.WriteLine(b1 + b1); // This adds b1 and writes to console 
// Console.WriteLine(b1 + s1); // you can add different types of numbers

// // ============ Booleans ==============
// bool hello = true;
// bool goodbye = false;

// Console.WriteLine(goodbye ? "I'm arriving" : "I'm leaving");
// Console.WriteLine(hello ? "I'm arriving" : "I'm leaving");

// // if else ============



// if (hello)
// {
//     Console.WriteLine("Inside if loop");
// }

// int i = 10, j = 20;

// if (i > j)
// {
//     Console.WriteLine("i is less than j");
// }

// else
// {
//     Console.WriteLine("inside else I am");
// }


// switch (i)
// {
//     case < 0:
//         Console.WriteLine("I is less than 0");
//         break;

//     case > 11:
//         Console.WriteLine("I is greater than 11");
//         break;

//     case 10:
//         Console.WriteLine("I is equivalent to 10");
//         break;
//     default:
//         Console.WriteLine("Default hit");
//         break;

// }

// // Array with strings inside
// string[] stringArray1 = new string[] { "Hello", "World", "My", "Name", "is", "Ben" };
// string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
// // Console.WriteLine(stringArray1[0] + stringArray1[1]);

// // foreach loop
// foreach (string word in stringArray1)
// {
//     Console.WriteLine(word);
// }
// Made a class called car. It has a color of red that is assigned to call new objects made from that class
class Car 
{
  public string color = "red"; // Public makes this accessible to other classes
}

class Program
{
    // THis is a mETHOD! 
    static void MyMethod()
    {
Console.WriteLine("I Just got executed!");
    }  
    
    static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
    MyMethod();
  }
}

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Enter your age");

int userAge = Int32.Parse(Console.ReadLine()); 
if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else 
{
    Console.WriteLine("You are too young to use Instagram");
}

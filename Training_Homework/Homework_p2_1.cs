// 1. Write a program that reads a number from the keyboard. Check whether that number is divisible by 7 and 11 or not.

using System.Numerics;
using System.Transactions;

Console.WriteLine("Enter a number: ");
string inputNr = Console.ReadLine();

if (string.IsNullOrEmpty(inputNr))
{
    Console.WriteLine($"{inputNr} is null or empty!");
}
else if (char.TryParse(inputNr, out _))
{
    Console.WriteLine($"Oops, {inputNr} is not a number!");
}
else if (Int32.TryParse(inputNr, out _))
{

    if (Int32.Parse(inputNr) % 7 == 0)
    {
        Console.WriteLine($"The number {inputNr} is divisible with 7 ");
    }
    else
    {
        Console.WriteLine($"The number {inputNr} is not divisible with 7");
    }

    if (Int32.Parse(inputNr) % 11 == 0)
    {
        Console.WriteLine($"The number {inputNr} is divisible with 11 ");
    }
    else
    {
        Console.WriteLine($"The number {inputNr} is not divisible with 11");
    }

}
else if (double.TryParse(inputNr, out _))
{
    Console.WriteLine($"{inputNr} is floating point type. Try again with an integer value.");
}

else
{
    Console.WriteLine("Oops, You've entered a string instead of number.Try again");
}

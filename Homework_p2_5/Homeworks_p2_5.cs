// Find the sum of digits of a number read from the keyboard.
 int sum;
 Console.WriteLine("Enter a number");
 string inNumber = Console.ReadLine();

if (Int32.TryParse(inNumber, out _))
{
    sum = inNumber.ToString().Sum(x => x - '0');
    Console.WriteLine($"The sum of the number digits is: {sum}");
}

else if (string.IsNullOrEmpty(inNumber) || double.TryParse(inNumber, out _))
{
    Console.WriteLine($"Oops, {inNumber} is not an integer number! Try again");
}



// +, -. *, / , %   operations with int values from console input

using System.Diagnostics.Metrics;

Console.WriteLine("Enter an integer value. varA = ");
int varA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter an integer value. varB = ");
int varB = int.Parse(Console.ReadLine());
int addRes = varA + varB;
int substRes = varA - varB;
int multRes = varA * varB;
int divRes = varA / varB;
int moduloRes = varA % varB;

Console.WriteLine($" addition = {addRes}, substraction = {substRes}, multiplication = {multRes}, division = {divRes}, modulo = {moduloRes}");
//Console.WriteLine( "result = " + addRes.ToString());
//Console.WriteLine( "result = " + addRes);






//-----------------------------------------------------------------------------------------------------------
// Console input data type check

Console.WriteLine("Checking the input data type. Enter the first value: ");
string input1 = Console.ReadLine();
Console.WriteLine("Checking the input data type. Enter the second value");
string input2 = Console.ReadLine();

if (string.IsNullOrEmpty(input1))
{
    Console.WriteLine($"{input1} is null or empty");
}
else if (Int32.TryParse(input1, out _))
{
    Console.WriteLine($"{input1} is integer type");
}
else if (double.TryParse(input1, out _))
{
    Console.WriteLine($"{input1} is floating point type");
}
else if (bool.TryParse(input1, out _))
{
    Console.WriteLine($"{input1} is boolean type");
}
else if (char.TryParse(input1, out _))
{
    Console.WriteLine($"{input1} is character type");
}
else // since you cannot parse to string ... if the previous statements came up false -> IT's STRING Type.
{
    Console.WriteLine($"{input1} is string type");
}




if (string.IsNullOrEmpty(input2))
{
    Console.WriteLine($"{input2} is null or empty");
}
else if (Int32.TryParse(input2, out _))
{
    Console.WriteLine($"{input2} is integer type");
}
else if (double.TryParse(input2, out _))
{
    Console.WriteLine($"{input2} is floating point type");
}
else if (bool.TryParse(input2, out _))
{
    Console.WriteLine($"{input2} is boolean type");
}
else if (char.TryParse(input2, out _))
{
    Console.WriteLine($"{input2} is character type");
}
else // since you cannot parse to string ... if the previous statements came up false -> IT's STRING Type.
{
    Console.WriteLine($"{input2} is string type");
}








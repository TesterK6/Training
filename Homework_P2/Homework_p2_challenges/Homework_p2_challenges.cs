// 1. Convert Binary 10011010 to Decimal number system.

Console.WriteLine("10011010 to decimal:" + Convert.ToInt32("10011010", 2).ToString());

//2. .Find an optimal solution to the code that converts a decimal to binary.

Console.WriteLine("Enter a decimal number");
string nr = Console.ReadLine();
string baseTwo = Convert.ToString(Int32.Parse(nr), 2);
Console.WriteLine($" {nr} to binary: {baseTwo}");
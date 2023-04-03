// 2. Check whether a given year is leap year or not.
using System.Numerics;
using System.Transactions;

Console.WriteLine("Enter a year: ");
string year = Console.ReadLine();

if (string.IsNullOrEmpty(year))
{
    Console.WriteLine($"{year} is null or empty!");
}
else if (char.TryParse(year, out _))
{
    Console.WriteLine($"Oops, {year} is not a number!");
}
else if (Int32.TryParse(year, out _))
{

    if (Int32.Parse(year) % 4 == 0)
    {
        Console.WriteLine($"The year {year} is leap ");
    }
    else
    {
        Console.WriteLine($"The {year} is not leap ");
    }

  
}
else if (double.TryParse(year, out _))
{
    Console.WriteLine($"{year} is floating point type. Try again with a realistic year value ;) .");
}

else
{
    Console.WriteLine("Oops, You've entered a string instead.Try again");
}

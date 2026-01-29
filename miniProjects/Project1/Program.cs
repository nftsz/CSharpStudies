// at this point I haven't learned if statments, loops or user input
// in C# yet but I've decided to try

using System.Diagnostics;

Console.WriteLine("Welcome to your Super Calculator");
Console.WriteLine("Choose an option:");
Console.WriteLine("[1] Sum  [2] Difference  [3] Product  [7] Square Root  [0] Quit ");
//  [4] Quotient   [5] Modulus  [6] Power  [7] Square Root

// The Console.ReadLine() method returns a string, use Convert method
int userOption = Convert.ToInt32(Console.ReadLine());
double firstNumber = 0;
double secondNumber = 0;

// for loop in future
if (userOption != 0)
{
    if (userOption != 7)
    {
        Console.WriteLine("Enter the first number:");
        firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        secondNumber = Convert.ToDouble(Console.ReadLine());

        if (userOption == 1)
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        }
        else if (userOption == 2)
        {
            double result = firstNumber - secondNumber;
            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
        }
        else if (userOption == 3)
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
        }
    }
    else if (userOption == 7)
    {
        Console.WriteLine("Enter the number:");
        firstNumber = Convert.ToDouble(Console.ReadLine());

        double result = System.Math.Sqrt(firstNumber);
        Console.WriteLine($"√{firstNumber} = {result}");
    }

}

// else {break;}

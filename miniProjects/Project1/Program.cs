// at this point I haven't learned if statments, loops or user input
// in C# yet but I've decided to try

Console.WriteLine("Welcome to your Super Calculator");
Console.WriteLine("Choose an option:");
Console.WriteLine("[1] Sum  [2] Difference  [3] Product  [0] Quit ");
//  [4] Int Quotient   [5] Decimal Quotient   [6] Modulus

// The Console.ReadLine() method returns a string, use Convert method
int userOption = Convert.ToInt32(Console.ReadLine());

// for loop in future
if (userOption != 0)
{
    if (userOption == 1)
    {
        Console.WriteLine("Pls give 2 numbers: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int result = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
    }
    else if (userOption == 2)
    {
        Console.WriteLine("Pls give 2 numbers: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int result = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
    }
    else if (userOption == 3)
    {
        Console.WriteLine("Pls give 2 numbers: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int result = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
    }

}
// else {break;}

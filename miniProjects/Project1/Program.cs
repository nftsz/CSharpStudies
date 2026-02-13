// at this point I haven't learned if statments, switch, loops or user input
// in C# yet but I've decided to try

Console.WriteLine("Welcome to your Super Calculator");
Console.WriteLine("Choose an option:");
Console.WriteLine("[1] Sum  [2] Difference  [3] Product  [4] Quotient  [5] Modulus  [6] Power  [7] Square Root  [0] Quit ");

// The Console.ReadLine() method returns a string, use Convert method
int userOption = Convert.ToInt32(Console.ReadLine());


if (userOption == 0)
{
    Console.WriteLine("Bye!");
    // break;
}
else if (userOption == 7)
{
    Console.WriteLine("Enter the number:");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"√{number} = {Math.Sqrt(number)}");
}
else if (userOption >= 1 && userOption <= 6)
{
    Console.WriteLine("Enter the first number:");
    double firstNumber = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    double secondNumber = Convert.ToDouble(Console.ReadLine());

    switch (userOption)
    {
        case 1:
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            break;

        case 2:
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            break;

        case 3:
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            break;

        case 4:
            if (secondNumber == 0)
                Console.WriteLine("Cannot divide by zero");
            else
                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            break;

        case 5:
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
            break;

        case 6:
            Console.WriteLine($"{firstNumber} ^ {secondNumber} = {Math.Pow(firstNumber, secondNumber)}");
            break;
    }
}
else
{
    Console.WriteLine("Invalid option");
}

public static class Ex02
{
    public static void Run()
    {
        Console.WriteLine("\n*********************************************************");
        Console.WriteLine("Ordens: [(); ^; *, /, %; +, -.] PEMDAS");
        // operacoes numericas 
        int first = 7;
        int second = 5;

        int sum = first + second;
        int difference = first - second;
        int product = first * second;
        int quotient = first / second;
        decimal quotientDecimal = (decimal)first / (decimal)second;
        decimal modulus = first % second;

        Console.WriteLine($"Soma: {first} + {second} = {sum}");
        Console.WriteLine($"Subtracao: {first} - {second} = {difference}");
        Console.WriteLine($"Multiplicacao:  {first} * {second} = {product}");
        Console.WriteLine($"Divisao inteira: {first} / {second} = {quotient}");
        Console.WriteLine($"Divisao Decimal: (decimal){first} / (decimal){second} = {quotientDecimal}");
        Console.WriteLine($"Resto:  {first} % {second} = {modulus}");

        int fahrenheit = 94;
        decimal celsius = (fahrenheit - 32) * ((decimal)5 / 9);
        Console.WriteLine($"The temperature is {celsius} celsius");

    }
}



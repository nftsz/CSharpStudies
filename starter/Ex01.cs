public static class Ex01
{
	public static void Run()
	{
		Console.WriteLine("Hello, tata 👋");
		Console.Write("Congratulations! ");
		Console.WriteLine("You wrote your first lines of code.\n");

		Console.WriteLine("*********************************************************");

		// valor literal = valor constante, nunca alterado
		Console.WriteLine("Literal Values");
		Console.WriteLine("------------------------");
		// aspas simples (') cria um char literal.
		Console.WriteLine("Single Quotes   |  Literal Char");
		// aspas duplas criam uma string
		Console.WriteLine("Double Quotes   |  String");
		Console.WriteLine("Booleans        |  bool ('true' or 'false')");
		Console.WriteLine("Integer Numb    |  Literal Int");
		Console.WriteLine("Decimal Num     |  Float, Double ou Decimal\n");

		Console.WriteLine("\tFloat Type    Precision");
		Console.WriteLine("\t----------------------------");
		Console.WriteLine("\tfloat         ~6-9 digits");
		Console.WriteLine("\tdouble        ~15-17 digits");
		Console.WriteLine("\tdecimal       28-29 digits\n");


		Console.WriteLine("\tExamples: ");
		Console.WriteLine("\tFloat: 0.25F"); // float
		Console.WriteLine("\tDouble: 2.625"); // double
		Console.WriteLine("\tDecimal: 12.39816M\n"); // decimal

		Console.WriteLine("*********************************************************");

		// Variables and string formatting
		string firstName = "tata";
		decimal temperatureInCelsius = 34.4M;
		int newMessages = 3;
		var infoMessage = $"The temperature is {temperatureInCelsius} celsius";

		Console.Write($"Hello, {firstName}! You have {newMessages} new messages in your inbox. ");
		Console.WriteLine(infoMessage);

		Console.WriteLine($"\nGenerating \"{firstName}'s mailbox\" log ...\n");
		Console.WriteLine("⣿⣿⣿⣿⣿\t\t 5/10\t Loading...");
		Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\t 7/10\t Loading...");
		Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 10/10\t Complete!\n");
		Console.WriteLine($@"Successfully! Stored in ""C:\Users\{firstName}\Documents\mailbox.txt\""");


		// Kon'nichiwa with UTF-16
		//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F");

		// Nihon no seikyū-sho o seisei suru ni wa:
		//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

		//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
	}
}



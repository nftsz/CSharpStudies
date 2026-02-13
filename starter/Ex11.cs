public static class Ex11
{
    public static void Run()
    {
        string letter1 = "Y";
        string letter2 = "y";

        Console.WriteLine(letter1.Trim().ToLower() == letter2.Trim().ToLower());

        Random coin = new Random();
        int flip = coin.Next(0, 2);
        Console.WriteLine((flip == 0) ? "heads" : "tails");

        string permission = "Admin|Manager";
        int level = 55;
        // Console.WriteLine((level == 55) ? permission.Split("|")[0] : permission.Split("|")[1] );

        if (permission.Contains("Admin"))
        {
           if (level > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else
            {
                Console.WriteLine("Welcome, Admin user.");
            }
        }
        else if (permission.Contains("Manager"))
        {
            if (level >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else
            {
                Console.WriteLine("You don't have sufficient privileges");
            }
        }
        else
        {
            Console.WriteLine("You don't have sufficient privileges");
        }
    }
}
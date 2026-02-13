public static class Ex08
{
    public static void Run()
    {
        /*
        string[] fraudulentOrdersIDs = new string[3];

        fraudulentOrdersIDs[0] = "A123";
        fraudulentOrdersIDs[1] = "B456";
        fraudulentOrdersIDs[2] = "C789";
        */

        // [] or {}
        string[] fraudulentOrdersIDs = [ "A123", "B456", "C789" ];

        Console.WriteLine($"First: {fraudulentOrdersIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrdersIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrdersIDs[2]}");

        fraudulentOrdersIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrdersIDs[0]}"); 

        Console.WriteLine($"There are {fraudulentOrdersIDs.Length} fraudulent orders to process."); 

    }
}
public static class Ex010
{
    public static void Run()
    {
        string[] fraudulentOrdersIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

        foreach (string orderID in fraudulentOrdersIDs)
        {
            if (orderID.StartsWith("B"))
            {
                Console.WriteLine(orderID);
            }
        }
    }
}


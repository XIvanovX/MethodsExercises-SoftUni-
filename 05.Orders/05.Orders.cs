namespace _05.Orders;
class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        PrintPrice(product, quantity);

        

       
    }

    static void PrintPrice(string product, int qunatity)
    {
        double priceCoffee = 1.5;
        double priceWater = 1.00;
        double priceCoke = 1.4;
        double priceSnacks = 2;

        double finalPrice = 0;

        switch(product)
        {
            case "coffee":
                finalPrice = priceCoffee * qunatity;
                break;
            case "water":
                finalPrice = priceWater * qunatity;
                break;
            case "coke":
                finalPrice = priceCoke * qunatity;
                break;
            case "snacks":
                finalPrice = priceSnacks * qunatity;
                break;

        }
        Console.WriteLine($"{finalPrice:f2}");
    }
}


namespace Structures;
class Program
{
    static void Main(string[] args)
    {
        MyDate startDate = new MyDate(2023, 12, 30, 12, 30);
        MyDate finishDate = new MyDate(2023, 12, 30, 15, 30);
        Airplane airplane = new Airplane("Kyiv", "Zhytomyr", startDate, finishDate);
        int totalTime = airplane.GetTotalTime();
        bool isArrivingToday = airplane.IsArrivingToday();
        Console.WriteLine($"Total travel time: {totalTime} minutes.");
        Console.WriteLine($"Same depart/arrival date: {isArrivingToday}.\n");
        Currency currency = new Currency("USD", 37.48);
        Product product = new Product("Chocolate", 3.5, currency, 1000, "USA Chocolate Factory", 0.5);
        double priceUAH = product.GetPriceInUAH();
        double totalPriceUAH = product.GetTotalPriceInUAH();
        double totalWeight = product.GetTotalWeight();
        Console.WriteLine($"Price in UAH: {Math.Round(priceUAH, 2)}.");
        Console.WriteLine($"Total price in UAH: {Math.Round(totalPriceUAH, 2)}.");
        Console.WriteLine($"Total weight: {Math.Round(totalWeight, 2)} kg.");
    }
}
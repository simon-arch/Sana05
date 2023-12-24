using Structures;
public class Product
{
    protected string Name;
    protected double Price;
    protected Currency Cost;
    protected int Quantity;
    protected string Producer;
    protected double Weight;

    public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
    {
        Name = name;
        Price = price;
        Cost = cost;
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }

    public Product(double price, Currency cost, int quantity, double weight)
    {
        Price = price;
        Cost = cost;
        Quantity = quantity;
        Weight = weight;
    }
    public Product(Product obj)
    {
        Name = obj.Name;
        Price = obj.Price;
        Cost = obj.Cost;
        Quantity = obj.Quantity;
        Producer = obj.Producer;
        Weight = obj.Weight;
    }
    public Product()
    {
        Name = "Chocolate";
        Price = 3.5;
        Cost = new Currency();
        Quantity = 1000;
        Producer = "USA Chocolate Factory";
        Weight = 0.5;
    }
    public void SetName(string name)
    {
        if (name.Length > 0)
            Name = name;
    }
    public void SetPrice(double price)
    {
        if (price > 0)
            Price = price;
    }
    public void SetCost(Currency cost)
    {
        Cost = cost;
    }
    public void SetQuantity(int quantity)
    {
        if (quantity > 0)
            Quantity = quantity;
    }
    public void SetProducer(string producer)
    {
        if (producer.Length > 0)
            Producer = producer;
    }
    public void SetWeight(double weight)
    {
        if (weight > 0)
            Weight = weight;
    }
    public string GetName()
    {
        return Name;
    }
    public double GetPrice()
    {
        return Price;
    }
    public Currency GetCost()
    {
        return Cost;
    }
    public int GetQuantity()
    {
        return Quantity;
    }
    public string GetProducer()
    {
        return Producer;
    }
    public double GetWeight()
    {
        return Weight;
    }
    public double GetPriceInUAH()
    {
        return Cost.GetExRate() * Price;
    }
    public double GetTotalPriceInUAH()
    {
        return Cost.GetExRate() * Price * Quantity;
    }
    public double GetTotalWeight()
    {
        return Quantity * Weight;
    }
}
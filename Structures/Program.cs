using System;

namespace Structures;
public class MyDate
{
    protected int Year;
    protected int Month;
    protected int Day;
    protected int Hours;
    protected int Minutes;
    public MyDate()
    {
        Year = DateTime.Now.Year;
        Month = DateTime.Now.Month;
        Day = DateTime.Now.Day;
        Hours = DateTime.Now.Hour;
        Minutes = DateTime.Now.Minute;
    }
    public void SetYear(int year)
    {
        if (year > 0) 
            Year = year;
    }
    public void SetMonth(int month)
    {
        if (month > 0 && month <= 12)
            Month = month;
    }
    public void SetDay(int day)
    {
        if (day > 0 && day <= 366)
            Day = day;
    }
    public void SetHours(int hours)
    {
        if (hours >= 0 && hours <= 23)
            Hours = hours;
    }
    public void SetMinutes(int minutes)
    {
        if (minutes >= 0 && minutes < 60)
            Minutes = minutes;
    }
    public int GetYear()
    {
        return Year;
    }
    public int GetMonth() 
    { 
        return Month; 
    }
    public int GetDay()
    {
        return Day;
    }
    public int GetHours()
    {
        return Hours;
    }
    public int GetMinutes()
    {
        return Minutes;
    }

}
public class Airplane
{
    protected string StartCity;
    protected string FinishCity;
    protected MyDate StartDate;
    protected MyDate FinishDate;
    public Airplane()
    {
        StartCity = "Kyiv";
        FinishCity = "Zhytomyr";
        StartDate = new MyDate();
        FinishDate = new MyDate();
    }
    public void SetStartCity(string startCity)
    {
        if(startCity.Length > 0)
            StartCity = startCity;
    }
    public void SetFinishCity(string finishCity)
    {
        if(finishCity.Length > 0)
            FinishCity = finishCity;
    }
    public void SetStartDate (MyDate startDate)
    {
        StartDate = startDate;
    }
    public void SetFinishDate (MyDate finishDate)
    {
        FinishDate = finishDate;
    }
    public string GetStartCity()
    {
        return StartCity;
    }
    public string GetFinishCity()
    {
        return FinishCity;
    }
    public MyDate GetStartDate()
    {
        return StartDate;
    }
    public MyDate GetFinishDate()
    {
        return FinishDate;
    }
    public int GetTotalTime()
    {
        DateTime startTime = new DateTime(StartDate.GetYear(), StartDate.GetMonth(), StartDate.GetDay(), StartDate.GetHours(), StartDate.GetMinutes(), 0);
        DateTime finishTime = new DateTime(FinishDate.GetYear(), FinishDate.GetMonth(), FinishDate.GetDay(), FinishDate.GetHours(), FinishDate.GetMinutes(), 0);
        int totalTime = (int)(finishTime - startTime).TotalMinutes;
        return totalTime;
    }
    public bool IsArrivingToday()
    {
        return (StartDate.GetYear() == FinishDate.GetYear() && StartDate.GetMonth() == FinishDate.GetMonth() && StartDate.GetDay() == FinishDate.GetDay());
    }
}

public class Product
{
    protected string Name;
    protected double Price;
    protected Currency Cost;
    protected int Quantity;
    protected string Producer;
    protected double Weight;
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
public class Currency
{
    protected string Name;
    protected double ExRate;
    public Currency()
    {
        Name = "USD";
        ExRate = 37.48;
    }
    public void SetName(string name)
    {
        if (name.Length > 0)
            Name = name;
    }
    public void SetExRate(double exRate)
    {
        if (exRate > 0)
            ExRate = exRate;
    }
    public string GetName()
    {
        return Name;
    }
    public double GetExRate()
    {
        return ExRate;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyDate startDate = new MyDate();
        startDate.SetYear(2023);
        startDate.SetMonth(12);
        startDate.SetDay(30);
        startDate.SetHours(12);
        startDate.SetMinutes(30);

        MyDate finishDate = new MyDate();
        finishDate.SetYear(2023);
        finishDate.SetMonth(12);
        finishDate.SetDay(30);
        finishDate.SetHours(15);
        finishDate.SetMinutes(30);

        Airplane airplane = new Airplane();
        airplane.SetStartCity("Kyiv");
        airplane.SetFinishCity("Zhytomyr");
        airplane.SetStartDate(startDate);
        airplane.SetFinishDate(finishDate);

        int totalTime = airplane.GetTotalTime();
        bool isArrivingToday = airplane.IsArrivingToday();

        Console.WriteLine($"Total travel time: {totalTime} minutes.");
        Console.WriteLine($"Same depart/arrival date: {isArrivingToday}.");

        Currency currency = new Currency();
        currency.SetName("USD");
        currency.SetExRate(37.48);

        Product product = new Product();
        product.SetName("Chocolate");
        product.SetPrice(3.5);
        product.SetCost(currency);
        product.SetQuantity(1000);
        product.SetProducer("USA Chocolate Factory");
        product.SetWeight(0.5);

        double priceUAH = product.GetPriceInUAH();
        double totalPriceUAH = product.GetTotalPriceInUAH();
        double totalWeight = product.GetTotalWeight();

        Console.WriteLine($"Price in UAH: {Math.Round(priceUAH, 2)}.");
        Console.WriteLine($"Total price in UAH: {Math.Round(totalPriceUAH, 2)}.");
        Console.WriteLine($"Total weight: {Math.Round(totalWeight, 2)}.");
    }
}
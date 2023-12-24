public class Currency
{
    protected string Name;
    protected double ExRate;
    public Currency()
    {
        Name = "USD";
        ExRate = 37.48;
    }
    public Currency(string name, double exRate)
    {
        Name = name;
        ExRate = exRate;
    }
    public Currency(double exRate)
    {
        ExRate = exRate;
    }
    public Currency(Currency obj)
    {
        Name = obj.Name;
        ExRate = obj.ExRate;
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
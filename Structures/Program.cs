namespace Structures;
public class MyDate
{
    protected int Year;
    protected int Month;
    protected int Day;
    protected int Hours;
    protected int Minutes;
    public void SetYear(int year)
    {
        Year = year;
    }
    public void SetMonth(int month)
    {
        Month = month;
    }
    public void SetDay(int day)
    {
        Day = day;
    }
    public void SetHours(int hours)
    {
        Hours = hours;
    }
    public void SetMinutes(int minutes)
    {
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
    public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = startDate;
        FinishDate = finishDate;
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
        
        Airplane airplane = new Airplane("Kyiv", "Zhytomyr", startDate, finishDate);

        int totalTime = airplane.GetTotalTime();
        bool isArrivingToday = airplane.IsArrivingToday();

        Console.WriteLine($"Total travel time: {totalTime} minutes.");
        Console.WriteLine($"Same start-finish date: {isArrivingToday}.");
    }
}
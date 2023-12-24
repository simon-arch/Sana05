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
    public MyDate(int year, int month, int day, int hours, int minutes)
    {
        Year = year;
        Month = month;
        Day = day;
        Hours = hours;
        Minutes = minutes;
    }
    public MyDate(int day, int hours, int minutes)
    {
        Day = day;
        Hours = hours;
        Minutes = minutes;
    }
    public MyDate(MyDate obj)
    {
        Year = obj.Year;
        Month = obj.Month;
        Day = obj.Day;
        Hours = obj.Hours;
        Minutes = obj.Minutes;
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
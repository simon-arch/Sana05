using Structures;
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

    public Airplane(MyDate startDate, MyDate finishDate)
    {
        StartDate = startDate;
        FinishDate = finishDate;
    }

    public Airplane()
    {
        StartCity = "Kyiv";
        FinishCity = "Zhytomyr";
        StartDate = new MyDate();
        FinishDate = new MyDate();
    }
    public Airplane(Airplane obj)
    {
        StartCity = obj.StartCity;
        FinishCity = obj.FinishCity;
        StartDate = obj.StartDate;
        FinishDate = obj.FinishDate;
    }
    public void SetStartCity(string startCity)
    {
        if (startCity.Length > 0)
            StartCity = startCity;
    }
    public void SetFinishCity(string finishCity)
    {
        if (finishCity.Length > 0)
            FinishCity = finishCity;
    }
    public void SetStartDate(MyDate startDate)
    {
        StartDate = startDate;
    }
    public void SetFinishDate(MyDate finishDate)
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
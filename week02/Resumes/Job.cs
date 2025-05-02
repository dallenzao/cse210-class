public class Job{
    public string _company;
    public string _title;
    public int _startyear;
    public int _endyear;

    public void DisplayInfo(){
        Console.WriteLine($"{_title} ({_company}) {_startyear}-{_endyear}");
    }
}
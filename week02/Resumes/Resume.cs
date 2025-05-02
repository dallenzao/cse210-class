public class Resume{
    public string _name;
    public List<Job> _jobs;

    public Resume(string name, List<Job> joblist){
        _name = name;
        _jobs = joblist;
    }
    public void Display(){
        Console.WriteLine($"My name is {_name}. Here is my past employment:");
        foreach (Job job in _jobs){
            job.DisplayInfo();
        }
    }
}
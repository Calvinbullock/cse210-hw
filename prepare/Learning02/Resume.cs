public class Resume {
    public string _name;
    public List<Job> _jobs;


    public Resume(string name, List<Job> jobs)
    {
        _name = name;
        _jobs = jobs;
    }

    public void Display() {
        Console.WriteLine($"Name: {_name} {_jobs}");
    }
}
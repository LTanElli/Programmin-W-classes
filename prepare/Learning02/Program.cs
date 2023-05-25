using System;

class Program
{
    static void Main(string[] args)
    {
        //object or instance
        var job1 = new Job("Software Engineer", "EA Sports", "2014", "2020");
        var job2 = new Job("Quality Assurance Officer", "A24 Studios", "2010", "2023");

        //var myResume = new Resume("Lynn Tanner Elliott");

        job1.DisplayCompany();
        job2.DisplayJob();
        job1.DisplayFull();

       // DisplaySpace();


        // myResume._jobs.Add(job1);
        // myResume._jobs.Add(job2);

        // myResume.Display();
    }
}

//classification
public class Job
{
    //attributes or properties
    public string _jobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;

    //constructor
    public Job(string jt, string cm, string sy, string ey) {
        _jobTitle = jt;

        _company = cm;

        _startYear = sy;
        int sty = int.Parse(sy);

        _endYear = ey;
        int eny = int.Parse(ey);
    }

    //bahaviors or methods
    public void DisplayCompany() {
        Console.WriteLine($"Company: {_company}");
    }

    public void DisplayJob() {
        Console.WriteLine($"Job Title: {_jobTitle}");
    }

    public void DisplayStart() {
        Console.WriteLine($"Start Year: {_startYear}");
    }

    public void DisplayEnd() {
        Console.WriteLine($"End Year: {_endYear}");
    }

    // public void DisplaySpace() {
    //     Console.WriteLine();
    // }

    public string DisplayFull() {
        return $"Company: {_company} \nJob Title: {_jobTitle} \nEmployment: {_startYear} - {_endYear}";
    }
}

//classification
// public class Resume
// {
//     //attributes
//     public string _employeeName;
//     public List<Job> _jobs = new List<Job>();
    
    //constructor
    // public Resume(string nm, List<Job> jb) {
    //     _employeeName = nm;
    //     _jobs = jb;
    // }

    //methods
    // public void Display() {
    //     Console.WriteLine($"Name: {_employeeName}");
    //     Console.WriteLine($"Jobs: ");

    //     foreach (Job job in _jobs);

    //     job.Display();
    // }
//}
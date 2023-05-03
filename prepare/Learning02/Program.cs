using System;

class Program
{
    static void Main(string[] args)
    {
        //object or instance
        var job1 = new Job("Software Engineer", "EA Sports", "2014", "2020");
        var job2 = new Job("Quality Assurance Officer", "A24 Studios", "2010", "2023");

        job1.DisplayCompany();
        job2.DisplayJob();
        job1.DisplayFull();

    }
}

//classification
public class Job
{
    //attributes or properties
    string _jobTitle;
    string _company;
    string _startYear;
    string _endYear;

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

    public void DisplaySpace() {
        Console.WriteLine();
    }

    public string DisplayFull() {
        return $"Company: {_company} \nJob Title: {_jobTitle} \nEmployment: {startYear} - {endYear}"
    }
}

public class Resume
{

}
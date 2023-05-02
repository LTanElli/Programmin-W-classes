using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job("Software Engineer");
        var job2 = new Job("Quality Assurance Officer");


    }
}

public class Job
{
    string _jobTitle;
    string _company;
    string _startYear;
    string _endYear;

    public Job(string jt, string cm, string sy, string ey) {
        _jobTitle = jt;

        _company = cm;

        _startYear = sy;
        int sty = int.Parse(sy);

        _endYear = ey;
        int eny = int.Parse(ey);
    }

    public void Display(); {
        Console.WriteLine($"");
    }

}

public class Resume
{

}
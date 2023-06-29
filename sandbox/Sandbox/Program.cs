using System;

class Program
{
    static void Main(string[] args)
    {
        var hourly = new HourlyEmployee(90000, "Elon Musk", 14);
        var salary = new SalaryEmployee(90000000, "Jeffrey Bezos", 14);

        var employees = new List<Employee> { hourly, salary };

        foreach (var employee in employees) {
            Console.WriteLine(employee._name);
            Console.WriteLine(employee.PayPeriodWages());
            Console.WriteLine("------------");
            
        }
    }    
}

public class Employee 
{
    public string _name;
    protected double _payPeriodLength;

    public Employee(string name, int payPeriodLength) {
        _name = name;
        _payPeriodLength = payPeriodLength;
    }

    virtual public double PayPeriodWages() {
        return 0;
    }
}
public class HourlyEmployee : Employee
{
    double _rate;

    public HourlyEmployee( double rate, string name, int payPeriodLength) : base(name, payPeriodLength) {
        _rate = rate;
    }

    public override double PayPeriodWages() {
        return _rate * 8 * _payPeriodLength;
    }
}

public class SalaryEmployee : Employee
{
    double _annualRate;

    public SalaryEmployee(double annualRate, string name, int payPeriodLength) : base(name, payPeriodLength) {
        _annualRate = annualRate;
    }

    public override double PayPeriodWages() {
        return (_payPeriodLength / 365.0) * _annualRate;
    }
}
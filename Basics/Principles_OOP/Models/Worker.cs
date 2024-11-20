using System.Globalization;

namespace Basics.Principles_OOP.Models;

public class Worker : Human {
    private readonly CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("pt-BR");
    private double wage;
    private int hoursWorked;

    public Worker(string firstName, string lastName) : base(firstName, lastName) { }

    public Worker(string firstName, string lastName, double wage, int hoursWorked) : this(firstName, lastName) {
        Wage = wage;
        HoursWorked = hoursWorked;
    }

    public double Wage {
        get => wage;
        set => wage = value > 0 ? value : 0;
    }

    public int HoursWorked {
        get => hoursWorked;
        set => hoursWorked = value > 0 ? value : 0;
    }

    public double CalculateHourlyWage() {
        double payRate = Wage * HoursWorked;

        return payRate;
    }

    public override string ToString() {
        return base.ToString() +
               "\nWage: " + Wage.ToString("C2", cultureInfo) +
               "\nHours worked: " + HoursWorked.ToString() +
               "\nHourly wage: " + CalculateHourlyWage().ToString("C2", cultureInfo);
    }
}
namespace Basics.Principles_OOP.Models;

public class Worker : Human {
    private double wage;
    private int hoursWorked;

    public Worker(string firstName, string lastName) : base(firstName, lastName) {
    }

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
               "\nWage: R$" + Wage.ToString("F2") +
               "\nHours worked: " + HoursWorked.ToString() +
               "\nHourly wage: R$" + CalculateHourlyWage().ToString("F2");
    }
}
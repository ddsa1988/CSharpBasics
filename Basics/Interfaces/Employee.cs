namespace Basics.Interfaces;

public class Employee : IEmployee, IManager {
    private int id;
    private double baseSalary;
    private double bonusAmount;
    private double expenseAllowance;

    public string Name { get; set; } = string.Empty;

    public int Id {
        get => id;
        set => id = value > 0 ? value : 0;
    }

    public double BaseSalary {
        get => baseSalary;
        set => baseSalary = value >= 0 ? value : 0;
    }

    public double BonusAmount {
        get => bonusAmount;
        set => bonusAmount = value >= 0 ? value : 0;
    }
    public double ExpenseAllowance {
        get => expenseAllowance;
        set => expenseAllowance = value >= 0 ? value : 0;
    }

    public void ShowData() {
        Console.WriteLine($"Name: {Name}\nID: {Id}\nBase Salary: {BaseSalary}\nBonus Amount: {BonusAmount}");
    }

    public double TotalSalary() {
        return BaseSalary + BonusAmount;
    }
}

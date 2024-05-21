namespace Basics.Interfaces;

public interface IEmployee {
    public string Name { get; set; }

    public int Id { get; set; }

    public double BaseSalary { get; set; }

    public double BonusAmount { get; set; }


    public void ShowData();

    public double TotalSalary();
}
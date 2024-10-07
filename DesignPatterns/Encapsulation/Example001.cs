namespace DesignPatterns.Encapsulation;

public class Example001 {
    public static void UserMain() {
        BankAccount bankAccount = new BankAccount(100);

        Console.WriteLine(bankAccount.Balance);

        bankAccount.Deposit(50);
        Console.WriteLine(bankAccount.Balance);

        bankAccount.Withdraw(100);
        Console.WriteLine(bankAccount.Balance);
    }
}
namespace DesignPatterns.Encapsulation;

public class BankAccount {
    public decimal Balance { get; private set; }

    public BankAccount() { }

    public BankAccount(decimal balance) {
        Deposit(balance);
    }

    public void Deposit(decimal amount) {
        if (amount <= 0) throw new ArgumentException("Deposit must be greater than zero.");

        Balance += amount;
    }

    public void Withdraw(decimal amount) {
        if (amount <= 0) throw new ArgumentException("Withdraw must be greater than zero.");

        if (amount > Balance) throw new InvalidOperationException("Insufficient balance.");

        Balance -= amount;
    }
}
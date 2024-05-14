namespace Basics.Inheritance;

public class Asset {
    private string name = string.Empty;

    public Asset(string name) {
        Name = name;
    }

    public string Name {
        get => name;
        set => name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? string.Empty : value;
    }

    public override bool Equals(object? obj) {
        if (obj is not Asset) return false;

        Asset? other = obj as Asset;

        return string.Equals(Name, other?.Name);
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override string ToString() {
        return "Name: " + Name;
    }
}

public class Stock : Asset {
    private long sharesOwned;

    public Stock(string name, long sharesOwned) : base(name) {
        SharesOwned = sharesOwned;
    }

    public long SharesOwned {
        get => sharesOwned;
        set => sharesOwned = Math.Abs(value);
    }

    public override string ToString() {
        return base.ToString() + "\nShares owned: " + SharesOwned;
    }
}

public class House : Asset {
    private double mortgage;

    public House(string name, double mortgage) : base(name) {
        Mortgage = mortgage;
    }

    public double Mortgage {
        get => mortgage;
        set => mortgage = Math.Abs(value);
    }

    public override string ToString() {
        return base.ToString() + "\nMortgage: " + Mortgage;
    }
}

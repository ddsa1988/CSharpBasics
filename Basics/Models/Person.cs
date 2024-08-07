﻿using System.Globalization;

namespace Basics.Models;

public class Person {
    private readonly string _name;

    public Person(string name) {
        Name = name;
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;

        if (!typeof(Person).IsInstanceOfType(obj)) return false;

        Person other = (Person)obj;

        return Name.Equals(other.Name);
    }

    public string Name {
        get => _name;
        init {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentNullException(nameof(value));
            }

            _name = value;
        }
    }

    public override string ToString() {
        return "Name: " + Name;
    }
}
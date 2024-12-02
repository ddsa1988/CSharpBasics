namespace Basics.Linq.Exercises;

public class Exercise004 {
    // Write a class Student with the following properties: first name, last name and age.
    // Create a LINQ query that finds the first and the last name of all students, aged between 18 and 24 years including
    public static void UserMain() {
       
    }

    private class Student {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        public override string ToString() {
            return "First name: " + FirstName +
                   ", Last name: " + LastName +
                   ", Age: " + Age;
        }

    }
}


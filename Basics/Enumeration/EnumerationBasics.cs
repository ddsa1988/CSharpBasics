using System.Collections;

namespace Basics.Enumeration;

public class EnumerationBasics {
    public static void UserMain() {
        {
            const string s1 = "Diego";

            using CharEnumerator enumerator = s1.GetEnumerator();
            while (enumerator.MoveNext()) {
                char element = enumerator.Current;
                Console.Write(element + " ");
            }
        }

        Console.WriteLine("\n");

        {
            People<string> people = new People<string>();
            people.Add("Diego");
            people.Add("Amanda");
            people.Add("Rodrigo");

            while (people.MoveNext()) {
                Console.WriteLine(people.Current);
            }

            people.Reset();

            Console.WriteLine();

            for (int i = 0; i < 10; i++) {
                people.MoveNext();
                Console.WriteLine(people.Current);
            }

            people.Reset();

            Console.WriteLine();
        }
    }

    public class People<T> : IEnumerable, IEnumerator {
        private readonly List<T> list = new List<T>();
        private int count = -1;

        public void Add(T item) {
            list.Add(item);
        }

        public IEnumerator GetEnumerator() {
            return (IEnumerator)this;
        }

        public bool MoveNext() {
            if (count >= Size() - 1) return false;

            count++;
            return true;
        }

        public object? Current {
            get {
                if (count < 0) return null;
                return list[count];
            }
        }

        public void Reset() {
            count = -1;
        }

        public int Size() {
            return list.Count;
        }
    }
}
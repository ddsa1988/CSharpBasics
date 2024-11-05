using Basics.LinearDataStructures.Models;
using Microsoft.VisualBasic;
using System.Collections;

namespace Basics.LinearDataStructures.Examples;

public class Example002 {
    // The ArrayList class is untyped, so it can keep all kinds of elements – numbers, strings and other objects.
    public static void UserMain() {
        {
            var list = new ArrayList();

            list.Add(1);
            list.Add(10.5f);
            list.Add("Diego");
            list.Add(DateTime.Now);

            foreach (object obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }

        {
            var list = new ArrayList();

            list.Add(2);
            list.Add(3.5f);
            list.Add(25u);
            list.Add(" EUR");

            dynamic sum = 0;

            foreach (object obj in list) {
                dynamic value = obj as dynamic;
                sum += value;
            }

            Console.WriteLine(sum);
        }
    }
}
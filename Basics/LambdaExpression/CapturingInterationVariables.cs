namespace Basics.LambdaExpression;

public class CapturingInterationVariables {
    public static void UserMain() {
        int arraySize = 3;

        {

            Action[] actions = new Action[arraySize];

            for (int i = 0; i < arraySize; i++) {
                actions[i] = () => Console.Write(i);
            }

            foreach (Action action in actions) {
                action(); //Print 333
            }
        }

        Console.WriteLine();

        {

            Action[] actions = new Action[arraySize];

            for (int i = 0; i < arraySize; i++) {
                int loopScoped = i;
                actions[i] = () => Console.Write(loopScoped);
            }

            foreach (Action action in actions) {
                action(); //Print 012
            }
        }
    }
}
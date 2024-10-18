using Basics.Classes.Models;

namespace Basics.Classes.Examples;

public class Example001 {
    public static void UserMain() {
        Dog firstDog = new Dog("Amora");
        Dog secondDog = new Dog("Ameixa");
        Dog thirdDog = new Dog();

        Dog[] dogs = [firstDog, secondDog, thirdDog];

        foreach (Dog dog in dogs) {
            dog.Bark();
        }
    }
}
namespace Basics.Generics.Models;

public class AnimalShelter<T> {
    private const int DefaultPlacesCount = 20;
    private readonly T?[] animalList;
    private int usedPlaces;

    public AnimalShelter() : this(DefaultPlacesCount) { }

    public AnimalShelter(int placesCount) {
        animalList = new T[placesCount];
        usedPlaces = 0;
    }

    public void Shelter(T newAnimal) {
        if (usedPlaces >= animalList.Length) {
            throw new InvalidOperationException("Shelter is full.");
        }

        animalList[usedPlaces++] = newAnimal;
    }

    public T? Release(int index) {
        if (index < 0 || index >= usedPlaces) {
            throw new ArgumentOutOfRangeException(nameof(index), $"Invalid cell index: {index}.");
        }

        T? releasedAnimal = animalList[index];

        for (int i = index; i < usedPlaces - 1; i++) {
            animalList[i] = animalList[i + 1];
        }

        animalList[--usedPlaces] = default(T);

        return releasedAnimal;
    }
}
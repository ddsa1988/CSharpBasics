namespace Basics.Linq.Models;

public static class ListExtensions {
    public static void IncreaseWith(this IList<int> list, int amount) {
        for (int i = 0; i < list.Count; i++) {
            list[i] += amount;
        }
    }
}
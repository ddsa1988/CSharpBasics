namespace FavoriteBands.Classes;
public class DataModel {
    private static List<string> bandList = new List<string>();

    public static bool AddItem(string bandName) {
        if (bandList.Contains(bandName)) return false;
        bandList.Add(bandName);
        return true;
    }

    public static void ShowItems() {
        if (bandList.Count > 0) {
            Console.WriteLine("List of bands:");

            foreach (string band in bandList) {
                Console.WriteLine(band);
            }
        } else {
            Console.WriteLine("The list of bands is empty.");
        }
    }
}

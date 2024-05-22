namespace FavoriteBands.Classes;

public class DataModel {
    private static readonly Dictionary<string, List<float>> BandList = new Dictionary<string, List<float>>() {
        { "ACDC", [10, 5, 6] },
        { "Metallica", [10, 5, 6, 5] },
        { "Iron Maiden", [10, 5, 6, 4, 3] }
    };

    public static bool AddItem(string? bandName) {
        if (string.IsNullOrEmpty(bandName) || string.IsNullOrWhiteSpace(bandName)) return false;

        if (BandList.ContainsKey(bandName)) return false;

        BandList.Add(bandName, new List<float>());
        return true;
    }

    public static void PrintItemsKeys() {
        if (BandList.Count > 0) {
            foreach (var band in BandList) {
                Console.WriteLine("Band: " + band.Key);
            }
        } else {
            Console.WriteLine("The list of bands is empty.");
        }
    }

    public static void PrintItemsValues() {
        if (BandList.Count > 0) {
            foreach (var band in BandList) {
                Console.Write($"Band: {band.Key}");

                if (band.Value.Count < 1) continue;

                Console.Write(" => Scores: [");

                for (int i = 0; i < band.Value.Count - 1; i++) {
                    Console.Write(band.Value[i] + ", ");
                }

                Console.Write(band.Value[band.Value.Count - 1] + "]");
                Console.Write($" => Avg: {CalculateScoreAvg(band.Value)}\n");
            }
        } else {
            Console.WriteLine("The list of bands is empty.");
        }
    }

    public static bool ListContainsKey(string? key) {
        return BandList.ContainsKey(key);
    }

    public static float CalculateScoreAvg(List<float> scores) {
        float sum = 0.0F;
        float avg = 0.0F;

        if (scores.Count < 1) return avg;

        foreach (float score in scores) {
            sum += score;
        }

        avg = sum / scores.Count;

        return avg;
    }
}
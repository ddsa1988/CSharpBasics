namespace Basics.NullableValueTypes;

public class ImplicitExplicitNullableConversion {
    public static void UserMain() {
        int? x = 10;

        if (x.HasValue) {
            int y = (int)x;
        }
    }
}
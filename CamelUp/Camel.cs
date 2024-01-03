namespace CamelUp {
    public class Camel {
        public CamelColor CamelColor;

        public Camel(CamelColor camelColor) {
            CamelColor = camelColor;
        }
    }

    public enum CamelColor {
        Blue = 0,
        Green = 1,
        Yellow = 2,
        White = 3,
        Orange = 4
    }
}

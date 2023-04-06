namespace Converter
{
    public class Values
    {
        // Значения и переменные для валют
        public float DOLLAR_TO_RUBLE = 79.5f;
        public float RUBLE_TO_DOLLAR = 0.013f;
        public float EURO_TO_RUBLE = 87.1f;
        public float RUBLE_TO_EURO = 0.011f;
        public float DOLLAR_TO_EURO = 0.91f;
        public float EURO_TO_DOLLAR = 1.09f;

        public float currencyX { get; set; }
        public float currencyY { get; set; }

        // Значения и переменные для масс
        public float GRAMS_TO_KILOGRAMS = 0.001f;
        public float GRAMS_TO_TONS = 0.000001f;
        public float KILOGRAMS_TO_GRAMS = 1000f;
        public float KILOGRAMS_TO_TONS = 0.001f;
        public float TONS_TO_GRAMS = 1000000f;
        public float TONS_TO_KILOGRAMS = 1000f;

        public float unitX { get; set; }
        public float unitY { get; set; }

        // Переменные для температур
        public float temperatureX { get; set; }
        public float temperatureY { get; set; }
    }
}

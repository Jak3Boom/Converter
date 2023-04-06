namespace Converter
{
    public class Selection
    {
        public void SelectionFromStartMenu(Values value, Conversion conversion)
        {
            Converters converter = new Converters();
            StartMenu startMenu = new StartMenu();
            ConsoleKeyInfo selection;
            do
            {
                startMenu.Print();
                selection = Console.ReadKey(true);
            } while (selection.Key != ConsoleKey.D1 && selection.Key != ConsoleKey.D2 && selection.Key != ConsoleKey.D3);

            switch (selection.Key)
            {
                // Конвертер валют
                case ConsoleKey.D1:
                    Console.Clear();
                    converter.Currency(value, conversion);
                    break;

                // Конвертер веса и масс
                case ConsoleKey.D2:
                    Console.Clear();
                    converter.Mass(value, conversion);
                    break;

                // Конвертер температур
                case ConsoleKey.D3:
                    Console.Clear();
                    converter.Temperature(value, conversion);
                    break;
            }
        }
    }
}

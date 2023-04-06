namespace Converter
{
    public class Conversion
    {
        // Процесс конвертации валют

        // Рубль -> Доллар
        public void RubleToDollar(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Рублей ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("конвертировать в "); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Доллары"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.currencyX = float.Parse(Console.ReadLine());
            value.currencyY = value.currencyX * value.RUBLE_TO_DOLLAR;

            Console.WriteLine();
            Console.Write(value.currencyX); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(" Рублей"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> " + value.currencyY); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Долларов"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Рубль -> Евро
        public void RubleToEuro(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Рублей ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("конвертировать в "); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Евро"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.currencyX = float.Parse(Console.ReadLine());
            value.currencyY = value.currencyX * value.RUBLE_TO_EURO;

            Console.WriteLine();
            Console.Write(value.currencyX); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(" Рублей"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> " + value.currencyY); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Евро"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Доллар -> Рубль
        public void DollarToRuble(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Долларов ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("конвертировать в "); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Рубли"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.currencyX = float.Parse(Console.ReadLine());
            value.currencyY = value.currencyX * value.DOLLAR_TO_RUBLE;

            Console.WriteLine();
            Console.Write(value.currencyX); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(" Долларов"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> " + value.currencyY); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Рублей"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Доллар -> Евро
        public void DollarToEuro(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Долларов ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("конвертировать в "); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Евро"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.currencyX = float.Parse(Console.ReadLine());
            value.currencyY = value.currencyX * value.DOLLAR_TO_EURO;

            Console.WriteLine();
            Console.Write(value.currencyX); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(" Долларов"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> " + value.currencyY); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Евро"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Евро -> Рубль
        public void EuroToRuble(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Евро ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("конвертировать в "); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Рубли"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.currencyX = float.Parse(Console.ReadLine());
            value.currencyY = value.currencyX * value.EURO_TO_RUBLE;

            Console.WriteLine();
            Console.Write(value.currencyX); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(" Евро"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> " + value.currencyY); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Рублей"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Евро -> Доллар
        public void EuroToDollar(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Евро ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("конвертировать в "); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Доллары"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.currencyX = float.Parse(Console.ReadLine());
            value.currencyY = value.currencyX * value.EURO_TO_DOLLAR;

            Console.WriteLine();
            Console.Write(value.currencyX); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(" Евро"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> " + value.currencyY); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Долларов"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Процесс конвертации масс

        // Граммы -> Килограммы
        public void GramsToKilograms(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Граммов ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Килограммы"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.unitX = float.Parse(Console.ReadLine());
            value.unitY = value.unitX * value.GRAMS_TO_KILOGRAMS;

            Console.WriteLine();
            Console.Write(value.unitX); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(" Граммов"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> {0:0.000}", value.unitY); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(" Килограммов"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Граммы -> Тонны
        public void GramsToTons(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Граммов ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Тонны"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.unitX = float.Parse(Console.ReadLine());
            value.unitY = value.unitX * value.GRAMS_TO_TONS;

            Console.WriteLine();
            Console.Write(value.unitX); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(" Граммов"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> {0:0.0000}", value.unitY); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(" Тонн"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Килограммы -> Граммы
        public void KilogramsToGrams(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Килограммов ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Граммы"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.unitX = float.Parse(Console.ReadLine());
            value.unitY = value.unitX * value.KILOGRAMS_TO_GRAMS;

            Console.WriteLine();
            Console.Write(value.unitX); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(" Килограммов"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> {0:0.00}", value.unitY); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(" Граммов"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Килограммы -> Тонны
        public void KilogramsToTons(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Килограммов ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Тонны"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.unitX = float.Parse(Console.ReadLine());
            value.unitY = value.unitX * value.KILOGRAMS_TO_TONS;

            Console.WriteLine();
            Console.Write(value.unitX); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(" Килограммов"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> {0:0.0000}", value.unitY); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(" Тонн"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Тонны -> Граммы
        public void TonsToGrams(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Тонн ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Граммы"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.unitX = float.Parse(Console.ReadLine());
            value.unitY = value.unitX * value.TONS_TO_GRAMS;

            Console.WriteLine();
            Console.Write(value.unitX); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(" Тонн"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> {0:0.00}", value.unitY); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(" Граммов"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Тонны -> Килограммы
        public void TonsToKilograms(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Тонн ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Килограммы"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.unitX = float.Parse(Console.ReadLine());
            value.unitY = value.unitX * value.TONS_TO_KILOGRAMS;

            Console.WriteLine();
            Console.Write(value.unitX); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(" Тонн"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> {0:0.00}", value.unitY); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(" Килограммов"); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Процесс конвертации температур

        // Градус Цельсия -> Градус Фаренгейта
        public void CelsiusToFahrenheit(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("°C ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("°F"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.temperatureX = float.Parse(Console.ReadLine());
            value.temperatureY = (value.temperatureX * 9 / 5) + 32;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"{value.temperatureX}°C"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("{0:0.0}°F", value.temperatureY); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Градус Цельсия -> Кельвин
        public void CelsiusToKelvin(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("°C ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("K"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.temperatureX = float.Parse(Console.ReadLine());
            value.temperatureY = value.temperatureX + 273.15f;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"{value.temperatureX}°C"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("{0:0.00}K", value.temperatureY); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Градус Фаренгейта -> Градус Цельсия
        public void FahrenheitToCelsius(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("°F ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("°C"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.temperatureX = float.Parse(Console.ReadLine());
            value.temperatureY = (value.temperatureX - 32) * 5 / 9;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"{value.temperatureX}°F"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("{0:0.0}°C", value.temperatureY); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Градус Фаренгейта -> Кельвин
        public void FahrenheitToKelvin(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("°F ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("K"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.temperatureX = float.Parse(Console.ReadLine());
            value.temperatureY = (value.temperatureX - 32) * 5 / 9 + 273.15f;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"{value.temperatureX}°F"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("{0:0.00}K", value.temperatureY); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Кельвин -> Градус Цельсия
        public void KelvinToCelsius(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("K ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("°C"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.temperatureX = float.Parse(Console.ReadLine());
            value.temperatureY = value.temperatureX - 273.15f;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"{value.temperatureX}K"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("{0:0.0}°C", value.temperatureY); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }

        // Кельвин -> Градус Фаренгейта
        public void KelvinToFahrenheit(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            Console.Write("Сколько "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("K ");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("перевести в "); Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("°F"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(": ");

            value.temperatureX = float.Parse(Console.ReadLine());
            value.temperatureY = (value.temperatureX - 273.15f) * 9 / 5 + 32;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"{value.temperatureX}K"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" -> "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("{0:0.00}°F", value.temperatureY); Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выход в главное меню
            ConsoleKeyInfo menuExit = Console.ReadKey(true);
            do
            {
                menuExit = Console.ReadKey(true);
            } while (menuExit.Key != ConsoleKey.Escape);

            Console.Clear();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }
    }
}

namespace Converter
{
    public class Converters
    {
        // Реализация конвертера валют
        public void Currency(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            // Заголовок страницы конвертера валют
            string currencyConverterText = "КОНВЕРТЕР ВАЛЮТ\n\n";
            Console.SetCursorPosition(Console.WindowWidth / 2 - currencyConverterText.Length / 2, 0);
            Console.WriteLine(currencyConverterText);

            Console.Write("Конвертация осуществляется следующим образом: "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Валюта X");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" -> ");
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Валюта Y\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выбор валюты X
            Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Валюту X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
            Console.WriteLine("1. Рубль\n" +
                              "2. Доллар\n" +
                              "3. Евро\n");

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            ConsoleKeyInfo selectCurrencyX;
            do
            {
                selectCurrencyX = Console.ReadKey(true);
            } while (selectCurrencyX.Key != ConsoleKey.D1 && selectCurrencyX.Key != ConsoleKey.D2 && selectCurrencyX.Key != ConsoleKey.D3 && selectCurrencyX.Key != ConsoleKey.Escape);

            switch (selectCurrencyX.Key)
            {
                // Валюта X - Рубль
                case ConsoleKey.D1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Валюта X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("Рубль\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор валюты Y для Рубля
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюту Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Доллар\n" +
                                      "2. Евро\n");

                    ConsoleKeyInfo selectCurrencyY;

                    do
                    {
                        selectCurrencyY = Console.ReadKey(true);
                    } while (selectCurrencyY.Key != ConsoleKey.D1 && selectCurrencyY.Key != ConsoleKey.D2);

                    switch (selectCurrencyY.Key)
                    {
                        // Валюта Y - Доллар
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюта Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Доллар\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Рубль -> Доллар
                            conversion.RubleToDollar(value, conversion);
                            break;

                        // Валюта Y - Евро
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюта Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Евро\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Рубль -> Евро
                            conversion.RubleToEuro(value, conversion);
                            break;
                    }

                    break;

                // Валюта X - Доллар
                case ConsoleKey.D2:
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Валюта X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("Доллар\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор валюты Y для Доллара
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюту Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Рубль\n" +
                                      "2. Евро\n");

                    do
                    {
                        selectCurrencyY = Console.ReadKey(true);
                    } while (selectCurrencyY.Key != ConsoleKey.D1 && selectCurrencyY.Key != ConsoleKey.D2);

                    switch (selectCurrencyY.Key)
                    {
                        // Валюта Y - Рубль
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюта Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Рубль\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Доллар -> Рубль
                            conversion.DollarToRuble(value, conversion);
                            break;

                        // Валюта Y - Евро
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюта Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Евро\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Доллар -> Евро
                            conversion.DollarToEuro(value, conversion);
                            break;
                    }
                    break;

                // Валюта X - Евро
                case ConsoleKey.D3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Валюта X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("Евро\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор валюты Y для Евро
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюту Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Рубль\n" +
                                      "2. Доллар\n");

                    do
                    {
                        selectCurrencyY = Console.ReadKey(true);
                    } while (selectCurrencyY.Key != ConsoleKey.D1 && selectCurrencyY.Key != ConsoleKey.D2);

                    switch (selectCurrencyY.Key)
                    {
                        // Валюта Y - Рубль
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюта Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Рубль\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Евро -> Рубль
                            conversion.EuroToRuble(value, conversion);
                            break;

                        // Валюта Y - Доллар
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("Валюта Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Доллар\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Доллар -> Рубль
                            conversion.EuroToDollar(value, conversion);
                            break;
                    }
                    break;

                case ConsoleKey.Escape:
                    Console.Clear();
                    startMenu.Print();
                    selection.SelectionFromStartMenu(value, conversion);
                    break;

            }
        }

        // Реализация конвертера масс
        public void Mass(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            // Заголовок страницы конвертера масс
            string massConverterText = "КОНВЕРТЕР ВЕСА И МАССЫ\n\n";
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(Console.WindowWidth / 2 - massConverterText.Length / 2, 0);
            Console.WriteLine(massConverterText);

            Console.Write("Конвертация осуществляется следующим образом: "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Единица измерения X");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" -> ");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Единица измерения Y\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выбор единицы измерения X
            Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Единицу измерения X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
            Console.WriteLine("1. Граммы\n" +
                              "2. Килограммы\n" +
                              "3. Тонны\n");

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            ConsoleKeyInfo unitX;

            do
            {
                unitX = Console.ReadKey(true);
            } while (unitX.Key != ConsoleKey.D1 && unitX.Key != ConsoleKey.D2 && unitX.Key != ConsoleKey.D3 && unitX.Key != ConsoleKey.Escape);

            switch (unitX.Key)
            {
                // Единица X - Граммы
                case ConsoleKey.D1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Единица измерения X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Граммы\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор единицы Y для граммов
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единицу измерения Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Килограммы\n" +
                                      "2. Тонны\n");

                    ConsoleKeyInfo unitY;

                    do
                    {
                        unitY = Console.ReadKey(true);
                    } while (unitY.Key != ConsoleKey.D1 && unitY.Key != ConsoleKey.D2);


                    switch (unitY.Key)
                    {
                        // Единица Y - Килограммы
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единица измерения Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Килограммы\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Граммы -> Килограммы
                            conversion.GramsToKilograms(value, conversion);
                            break;

                        // Единица Y - Тонны
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единица измерения Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Тонны\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Граммы -> Тонны
                            conversion.GramsToTons(value, conversion);
                            break;
                    }

                    break;


                // Единица X - Килограммы
                case ConsoleKey.D2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Единица измерения X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Килограммы\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор единицы Y для килограммов
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единицу измерения Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Граммы\n" +
                                      "2. Тонны\n");

                    do
                    {
                        unitY = Console.ReadKey(true);
                    } while (unitY.Key != ConsoleKey.D1 && unitY.Key != ConsoleKey.D2);

                    switch (unitY.Key)
                    {
                        // Единица Y - Граммы
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единица измерения Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Граммы\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Килограммы -> Граммы
                            conversion.KilogramsToGrams(value, conversion);
                            break;

                        // Единица Y - Тонны
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единица измерения Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Тонны\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Килограммы -> Тонны
                            conversion.KilogramsToTons(value, conversion);
                            break;
                    }

                    break;

                // Единица X - Тонны
                case ConsoleKey.D3:
                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("Единица измерения X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Тонны\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор единицы Y для килограммов
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единицу измерения Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Граммы\n" +
                                      "2. Килограммы\n");

                    do
                    {
                        unitY = Console.ReadKey(true);
                    } while (unitY.Key != ConsoleKey.D1 && unitY.Key != ConsoleKey.D2);

                    switch (unitY.Key)
                    {
                        // Единица Y - Граммы
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единица измерения Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Граммы\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Тонны -> Граммы
                            conversion.TonsToGrams(value, conversion);
                            break;

                        // Единица Y - Килограммы
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("Единица измерения Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Килограммы\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Тонны -> Килограммы
                            conversion.TonsToKilograms(value, conversion);
                            break;
                    }
                    break;

                case ConsoleKey.Escape:
                    Console.Clear();
                    startMenu.Print();
                    selection.SelectionFromStartMenu(value, conversion);
                    break;
            }
        }

        // Реализация конвертера температур
        public void Temperature(Values value, Conversion conversion)
        {
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();

            // Заголовок страницы конвертера температур
            string temperatureConverterText = "КОНВЕРТЕР ТЕМПЕРАТУР\n\n";
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(Console.WindowWidth / 2 - temperatureConverterText.Length / 2, 0);
            Console.WriteLine(temperatureConverterText);

            Console.Write("Конвертация осуществляется следующим образом: "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Единица температуры X");
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" -> ");
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Единица температуры Y\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

            // Выбор единицы температуры X
            Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Единицу температуры X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
            Console.WriteLine("1. Градус Цельсия\n" +
                              "2. Градус Фаренгейта\n" +
                              "3. Кельвин\n");

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Для выхода в главное меню нажмите Escape");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkGray;

            ConsoleKeyInfo temperatureX;

            do
            {
                temperatureX = Console.ReadKey(true);
            } while (temperatureX.Key != ConsoleKey.D1 && temperatureX.Key != ConsoleKey.D2 && temperatureX.Key != ConsoleKey.D3 && temperatureX.Key != ConsoleKey.Escape);

            switch (temperatureX.Key)
            {
                // Единица температуры X - Градус Цельсия
                case ConsoleKey.D1:
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Единица температуры X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Градус Цельсия\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор единицы температуры Y для Градуса Цельсия
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единицу температуры Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Градус Фаренгейта\n" +
                                      "2. Кельвин\n");

                    ConsoleKeyInfo temperatureY;

                    do
                    {
                        temperatureY = Console.ReadKey(true);
                    } while (temperatureY.Key != ConsoleKey.D1 && temperatureY.Key != ConsoleKey.D2);

                    switch (temperatureY.Key)
                    {
                        // Единица температуры Y - Градус Фаренгейта
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единица температуры Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Градус Фаренгейта\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Градус Цельсия -> Градус Фаренгейта
                            conversion.CelsiusToFahrenheit(value, conversion);
                            break;

                        // Единица температуры Y - Кельвин
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единица температуры Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Кельвин\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Градус Цельсия -> Кельвин
                            conversion.CelsiusToKelvin(value, conversion);
                            break;
                    }

                    break;

                // Единица температуры X - Градус Фаренгейта
                case ConsoleKey.D2:
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Единица температуры X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Градус Фаренгейта\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор единицы температуры Y для Градуса Фаренгейта
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единицу температуры Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Градус Цельсия\n" +
                                      "2. Кельвин\n");

                    do
                    {
                        temperatureY = Console.ReadKey(true);
                    } while (temperatureY.Key != ConsoleKey.D1 && temperatureY.Key != ConsoleKey.D2);

                    switch (temperatureY.Key)
                    {
                        // Единица температуры Y - Градус Цельсия
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единица температуры Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Градус Цельсия\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Градус Фаренгейта -> Градус Цельсия
                            conversion.FahrenheitToCelsius(value, conversion);
                            break;

                        // Единица температуры Y - Кельвин
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единица температуры Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Кельвин\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Градус Фаренгейта -> Кельвин
                            conversion.FahrenheitToKelvin(value, conversion);
                            break;
                    }

                    break;

                // Единица температуры X - Кельвин
                case ConsoleKey.D3:
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Единица температуры X");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Кельвин\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                    // Выбор единицы температуры Y для Кельвин
                    Console.Write("Выберите "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единицу температуры Y"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(":\n");
                    Console.WriteLine("1. Градус Цельсия\n" +
                                      "2. Градус Фаренгейта\n");

                    do
                    {
                        temperatureY = Console.ReadKey(true);
                    } while (temperatureY.Key != ConsoleKey.D1 && temperatureY.Key != ConsoleKey.D2);

                    switch (temperatureY.Key)
                    {
                        // Единица температуры Y - Градус Цельсия
                        case ConsoleKey.D1:
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единица температуры Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Градус Цельсия\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Кельвин -> Градус Цельсия
                            conversion.KelvinToCelsius(value, conversion);
                            break;

                        // Единица температуры Y - Кельвин
                        case ConsoleKey.D2:
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Единица температуры Y");
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" - ");
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("градус Фаренгейта\n"); Console.ForegroundColor = ConsoleColor.DarkGray;

                            // Процесс конвертации Кельвин -> Градус Фаренгейта
                            conversion.KelvinToFahrenheit(value, conversion);
                            break;
                    }
                    break;

                case ConsoleKey.Escape:
                    Console.Clear();
                    startMenu.Print();
                    selection.SelectionFromStartMenu(value, conversion);
                    break;
            }
        }
    }
}

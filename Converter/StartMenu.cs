namespace Converter
{
    public class StartMenu
    {
        // Стартовое меню
        public void Print()
        {
            // Название приложения
            string greeting = "КОНВЕРТЕР ВЕЛИЧИН\n\n";
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(Console.WindowWidth / 2 - greeting.Length / 2, 0);
            Console.WriteLine(greeting);

            // Предложение выбрать функции
            Console.WriteLine("Выберите то, что хотите конвертировать:\n\n");
            Console.WriteLine("1. Валюта\n" +
                              "2. Вес и масса\n" +
                              "3. Температура");
        }
    }
}

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов стартового меню
            StartMenu startMenu = new StartMenu();
            Selection selection = new Selection();
            Values value = new Values();
            Conversion conversion = new Conversion();
            startMenu.Print();
            selection.SelectionFromStartMenu(value, conversion);
        }
    }
}
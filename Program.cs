

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Нажмите любую клавишу для получение кода");
        while (true)
        {
            
            ConsoleKey key = Console.ReadKey().Key;

            int keyCode = (int)key;

            Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("Вы нажали Enter");
            }
        }
    }
}
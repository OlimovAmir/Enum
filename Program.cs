

using Enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Нажмите любую клавишу для получение кода");
        while (false)
        {
            
            ConsoleKey key = Console.ReadKey().Key;

            int keyCode = (int)key;

            Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("Вы нажали Enter");
            }
        }
        
        Enum.ClassDayOfWeek classDayOfWeek = new Enum.ClassDayOfWeek();

        classDayOfWeek.getTypeEnum();

        Console.WriteLine(classDayOfWeek);
        ClassDayOfWeek.DayOfWeek day = ClassDayOfWeek.DayOfWeek.Monday;
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(day);

        Type enumType = typeof(ClassDayOfWeek.DayOfWeek);
        Console.WriteLine("----------");
        Console.WriteLine(enumType);

        Console.WriteLine("Вызов Метода _____________________________");

        classDayOfWeek.getTypeEnum();



    }
}
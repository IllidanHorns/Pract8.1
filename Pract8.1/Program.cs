using Pract8._1;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;



public class TextWork
{
    internal static int LengthConsole = 0;
    internal static int HightConsole = 0;
    internal static double WordsInMinute = 0;
    internal static double WordsInSecond = 0;
    internal static int Chek = 1;
    internal static string UserName;
    internal static string TextForTest1 = "Элиас Дисней был глубоко религиозным мрачным человеком и " +
    "сурово относился к воспитанию детей. Его любимой была поговорка: «Пожалеешь розог — " +
    "испортишь ребёнка». Вместе с тем глава семейства по-своему любил семью и сумел привить " +
    "детям свои моральные ценности. Элиас Дисней учил детей быть честными и заботиться о репутации, " +
    "привил любовь к труду, научил преодолевать трудности и сострадать ближнему. Для Уолта эти " +
    "принципы стали главными в жизни. Он перенял лучшие отцовские качества: непоколебимость, " +
    "готовность идти на риск, трудолюбие, честность, любовь к семье. Мать Уолта Диснея, в свою " +
    "очередь, оказала огромное влияние на становление его личности. Она была очень спокойной женщиной " +
    "с выдержанным, но настойчивым характером и замечательным чувством юмора. Лёгкий и весёлый нрав " +
    "Флоры Дисней уравновешивал суровый характер отца семейства. ";
    public static void Main()
    {
        Console.SetCursorPosition(0, 0);
        Console.Clear();
        Console.WriteLine("Введите имя для таблицы рекордов ");
        UserName = Console.ReadLine();
        Console.Clear();
        Color(UserName);
    }
    private static void Color(string UserName)
    {
        LengthConsole = 0;
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(TextForTest1);
        Console.SetCursorPosition(0, 15);
        Console.WriteLine("Нажмите Enter, когда захотите начать!");
        while (true) 
        {
            var UserButton1 = Console.ReadKey(true);
            if (UserButton1.Key == ConsoleKey.Enter)
            {
                break;
            }
        }
        Thread TimerThread = new Thread(new ThreadStart(Taimer));
        TimerThread.Start();
        Console.SetCursorPosition(0,0);
        foreach (char symbol in TextForTest1)
        {
            if (Chek == 0)
            {
                Chek = 1;
                WordsInSecond = WordsInMinute / 60;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 14);
                while (true)
                {
                    User UserEndInformation = new User(UserName, WordsInMinute, WordsInSecond);
                    SaveRecords.Records(UserEndInformation);
                    WordsInMinute = 0;
                    WordsInSecond = 0;
                    Console.SetCursorPosition(0, 0);
                }
                break;
            }
            var UserButton = Console.ReadKey(true);
            if (UserButton.KeyChar == symbol)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(LengthConsole, HightConsole);
                Console.Write(symbol);
                LengthConsole++;
                WordsInMinute++;
                if (LengthConsole >= Console.BufferWidth)
                {
                    LengthConsole = 0;
                    HightConsole++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(LengthConsole, HightConsole);
                Console.Write(symbol);
                LengthConsole++;
                if (LengthConsole >= Console.BufferWidth)
                {
                    LengthConsole = 0;
                    HightConsole++;
                }
            }
        }

    }

    private static void Taimer()
    {
        int Minute = 1;
        int Second = 1;
        for (int i = 0; i < 61; i++) 
        {
            Console.SetCursorPosition(0, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------");
            if (i == 1)
            {
                Second = 60;
                Minute = 0;
            }
            Second--;
            Thread.Sleep(100);
            Console.SetCursorPosition(0, 11);
            Console.Write("                                                                       ");
            Console.SetCursorPosition(0, 11);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Minute + " : " + Second);
            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-----------");
        }
        Chek = 0;
    }

}





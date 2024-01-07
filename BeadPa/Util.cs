using System;
namespace BeadPa
{
	public static class Util
	{
        public static void Clear()
        {
            Console.Clear();
        }

        public static string Read(string txt = "")
        {
            PrintInLine(txt);
            return Console.ReadLine();
        }

        public static void PrintInLine(string txt)
        {
            Console.Write(txt);
        }

        public static DateTime ReadDate(string txt)
        {
            PrintInLine(txt);
            DateTime date;
            while (!DateTime.TryParse(Read(), out date))
            {
                Print("Invalid date format! pls try again (yyyy.mm.dd)");
            }
            return date;
        }
        public static void Print(string txt)
        {
            Console.WriteLine(txt);
        }

        public static void Wait(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void PrintList(List<Obj> list)
        {
            Console.WriteLine($"List objects:");
            foreach (var obj in list)
            {
                obj.Self();
            }
        }

    }
}


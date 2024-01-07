using System;
namespace BeadPa
{
	public static class Util
	{
        public static void Clear()
        {
            Console.Clear();
        }

        public static string Read()
        {
            return Console.ReadLine();
        }

        public DateTime ReadDate()
        {
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

        public static void PrintList(List<Obj> list)
        {
            Console.WriteLine($"List objects:");
            foreach (var obj in list)
            {
                obj.Hello();
            }
        }

    }
}


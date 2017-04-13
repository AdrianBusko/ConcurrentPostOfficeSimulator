using System;

namespace poczta
{
    class WlasciwosciOkna
    {
        public static void UstawienieOkna()
        {
            Console.Title = "Kamil Gałązka - > Projekt Poczty";
            Console.SetWindowSize(60, 60);
            Console.SetBufferSize(60, 60);
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("#############");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("#####");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("###########################");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("#####");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("##########");

            Console.SetCursorPosition(0, 58);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("#############################");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("#####");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("##########################");
        }
    }
}

using System.Net;

namespace Пианино
{
    internal class dower
    {
        static int[] CurOct = new int[12];
        static int[] FirstOctave = new int[] { 16, 18, 21, 22, 24, 28, 31, 17, 19, 23, 26, 29 };
        static int[] SecondOctave = new int[] { 33, 37, 41, 44, 49, 55, 62, 35, 39, 46, 52, 58 };
        static int[] ThirdOctave = new int[] { 65, 73, 82, 87, 98, 110, 123, 69, 78, 92, 104, 116 };
        static int[] FourOctave = new int[] { 261, 293, 329, 349, 392, 440, 493, 277, 311, 370, 415, 466 };
        static int[] ava(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("1я окт");
                    return FirstOctave;
                    break;
                case 2:
                    Console.WriteLine("2 окт");
                    return SecondOctave;
                    break;
                case 3:
                    Console.WriteLine("3 окт");
                    return ThirdOctave;
                    break;
                case 4:
                    Console.WriteLine("4 окт");
                    return FourOctave;
                    break;
                default:
                    Console.WriteLine("1я окт");
                    return FirstOctave;
                    break;
            }
            return CurOct;
        }

        private static int[] massiveCurOct = ava(1);

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Выберите октаву F1, F2, F3 или F4");
                Console.WriteLine("Клавиши доступные: A, S, D, F, G, H, J, Q, W, E, R и Y ");
                Console.WriteLine("Для выхода нажмите: Esc");
                oktava();
            }
        }

        static ConsoleKey oktava()
        {
            ConsoleKey aboba = Console.ReadKey().Key;

            switch (aboba)
            {
                case ConsoleKey.F1:
                    massiveCurOct = ava(1);
                    break;
                case ConsoleKey.F2:
                    massiveCurOct = ava(2);
                    break;
                case ConsoleKey.F3:
                    massiveCurOct = ava(3);
                    break;
                case ConsoleKey.F4:
                    massiveCurOct = ava(4);
                    break;
                case ConsoleKey.Escape:
                    System.Environment.Exit(0);
                    break;
                case ConsoleKey.A:
                    Console.Clear();
                    Console.Beep(massiveCurOct[0] + 1100, 200);
                    break;
                case ConsoleKey.S:

                    Console.Clear();
                    Console.Beep(massiveCurOct[1] + 1100, 200);
                    break;
                case ConsoleKey.D:

                    Console.Clear();
                    Console.Beep(massiveCurOct[2] + 1100, 200);
                    break;
                case ConsoleKey.F:

                    Console.Clear();
                    Console.Beep(massiveCurOct[3] + 1100, 200);
                    break;
                case ConsoleKey.G:

                    Console.Clear();
                    Console.Beep(massiveCurOct[4] + 1100, 200);
                    break;
                case ConsoleKey.H:

                    Console.Clear();
                    Console.Beep(massiveCurOct[5] + 1100, 200);
                    break;
                case ConsoleKey.J:

                    Console.Clear();
                    Console.Beep(massiveCurOct[6] + 1100, 200);
                    break;

                case ConsoleKey.W:

                    Console.Clear();
                    Console.Beep(massiveCurOct[7] + 1100, 200);
                    break;
                case ConsoleKey.Q:

                    Console.Clear();
                    Console.Beep(massiveCurOct[8] + 1100, 200);
                    break;
                case ConsoleKey.E:

                    Console.Clear();
                    Console.Beep(massiveCurOct[9] + 1100, 200);
                    break;
                case ConsoleKey.R:

                    Console.Clear();
                    Console.Beep(massiveCurOct[10] + 1100, 200);
                    break;
                case ConsoleKey.Y:

                    Console.Clear();
                    Console.Beep(massiveCurOct[11] + 1100, 200);
                    break;

            }
            return aboba;
        }


    }

}
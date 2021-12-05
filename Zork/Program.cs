using Newtonsoft.Json;
using System;
using System.IO;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 41);

            const string defaultGameFileName = "Zork.json";

            string gameFileName = args.Length > 0 ? args[(int)CommandLineArguments.GameFileName] : defaultGameFileName;

            ConsoleInputService input = new ConsoleInputService();

            ConsoleOutputService output = new ConsoleOutputService();

            Game.ConvertFile(gameFileName, input, output);

            output.WriteLine(Game.Instance.WelcomeMessage);

            output.WriteLine(Game.Instance.Player.CurrentRoom.Name);

            output.WriteLine(Game.Instance.Player.CurrentRoom.Description);

            Sound.PlaySound();

            DrawArt.Draw();

            while (Game.Instance.IsRunning)
            {
                output.Write("\n> ");

                input.GetInput();

                if (Game.Instance.Player.CurrentRoom != Game.Instance.Player.PerviousRoom)
                {
                    Game.Instance.Player.PerviousRoom = Game.Instance.Player.CurrentRoom;

                    Sound.PlaySound();

                    DrawArt.Draw();
                }
            }
        }

        private enum CommandLineArguments
        {
            GameFileName = 0
        }
    }
}
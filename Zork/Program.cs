using Newtonsoft.Json;
using System.IO;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFileName = "Zork.json";

            string gameFileName = args.Length > 0 ? args[(int)CommandLineArguments.GameFileName] : defaultGameFileName;

            ConsoleInputService input = new ConsoleInputService();

            ConsoleOutputService output = new ConsoleOutputService();

            Game.ConvertFile(gameFileName, input, output);

            output.WriteLine(Game.Instance.WelcomeMessage);

            while (Game.Instance.IsRunning)
            {
                if (Game.Instance.Player.PerviousRoom != Game.Instance.Player.CurrentRoom)
                {
                    output.WriteLine(Game.Instance.Player.CurrentRoom.Name);
                    output.WriteLine(Game.Instance.Player.CurrentRoom.Description);
                    Game.Instance.Player.PerviousRoom = Game.Instance.Player.CurrentRoom;
                }

                output.Write("\n> ");

                input.GetInput();
            }

            output.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFileName = 0
        }
    }
}
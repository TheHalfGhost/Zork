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

            output.WriteLine(Game.Instance.Player.CurrentRoom.Name);

            output.WriteLine(Game.Instance.Player.CurrentRoom.Description);

            while (Game.Instance.IsRunning)
            {
                output.Write("\n> ");

                input.GetInput();
            }
        }

        private enum CommandLineArguments
        {
            GameFileName = 0
        }
    }
}
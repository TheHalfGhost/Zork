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

            ConsoleOutputService output = new ConsoleOutputService();

            Game game = Game.Load(gameFileName, output);

            game.Run();
        }

        private enum CommandLineArguments
        {
            GameFileName = 0
        }
    }
}
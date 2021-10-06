using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        public string WelcomeMessage { get; set; }


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public void Run()
        {
            Console.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{Player.CurrentRoom.Name}\n> ");

                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Console.Write($"{Player.CurrentRoom.Description}\n> ");

                    Player.PreviousRoom = Player.CurrentRoom;
                }

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;

                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        Movement++;
                        outputString = Player.CurrentRoom.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Movement++;
                        outputString = Player.Move(command) ? $"You moved {command}." : "The way is shut";
                        break;

                    case Commands.REWARD:
                        Score++;
                        outputString = "Your score has increased";
                        break;

                    case Commands.SCORE:
                        outputString = $"Your score would be {Score}, in {Movement} move(s).";
                        break;

                    default:
                        outputString = "Unknown command";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKOWN;

        public int Score = 0;

        public int Movement = 0;

    }
}

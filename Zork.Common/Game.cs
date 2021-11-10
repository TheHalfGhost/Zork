using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public World World { get; private set; }

        public List<Room> Rooms { get; }

        public List<Room> Neighbors { get; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public IOutputService Output { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        public Game(World world, Player player)
        {
            World = world;

            Player = player;
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public void Run()
        {
            Output.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKOWN;

            while (command != Commands.QUIT)
            {
                Output.Write($"{Player.CurrentRoom.Name}\n> ");

                if (Player.PerviousRoom != Player.CurrentRoom)
                {
                    Output.Write($"{Player.CurrentRoom.Description}\n> ");

                    Player.PerviousRoom = Player.CurrentRoom;
                }

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;

                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        Player.Movement++;
                        outputString = Player.CurrentRoom.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Player.Movement++;
                        Directions directions = (Directions)command;
                        if (Player.Move(directions) == false)
                        {
                           outputString = "The way is shut";
                        }
                        else
                        {
                           
                           outputString = $"You moved {directions}";
                        }
                        break;

                    case Commands.REWARD:
                        Player.Score++;
                        outputString = "Your score has increased";
                        break;

                    case Commands.SCORE:
                        outputString = $"Your score would be {Player.Score}, in {Player.Movement} move(s).";
                        break;

                    default:
                        outputString = "Unknown command";
                        break;
                }

                Output.WriteLine(outputString);
            }
        }

        public static Game Load(string filename, IOutputService output)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));

            game.Player = new Player(game.World, game.StartingLocation);

            game.Output = output;

            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKOWN;
    }
}
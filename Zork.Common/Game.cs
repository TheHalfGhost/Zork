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

        [JsonIgnore]
        public IOutputService Output { get; set; }

        [JsonIgnore]
        public IInputService Input { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public static Game Instance { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; private set; }

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

        public static void ConvertFile(string filename, IInputService input, IOutputService output)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Expected file.", filename);
            }

            Start(File.ReadAllText(filename), input, output);
        }

        public static void Start(string gamejsonstring, IInputService input, IOutputService output)
        {
            while (Instance == null)
            {
                Instance = Load(gamejsonstring);
                Instance.Output = output;
                Instance.Input = input;
                Instance.IsRunning = true;
                Instance.Input.InputReceived += Instance.InputInputReceived;
            }
        }

        private void InputInputReceived(object sender, string inputstring)
        {
            Commands command = ToCommand(inputstring);

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

        public static Game Load(string jsonstring)
        {
            Game game = JsonConvert.DeserializeObject<Game>((jsonstring));

            game.Player = new Player(game.World, game.StartingLocation);

            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKOWN;
    }
}
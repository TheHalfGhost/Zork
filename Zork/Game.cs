﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Zork
{
    public class Game
    {
        public World World { get; private set; }

        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        public string WelcomeMessage { get; set; }

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
            Console.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{Player.CurrentRoom.Name}\n> ");

                if (Player.PerviousRoom != Player.CurrentRoom)
                {
                    Console.Write($"{Player.CurrentRoom.Description}\n> ");

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
                        Directions directions = Enum.Parse<Directions>(command.ToString(), true);
                        if (Player.Move(directions) == false)
                        {
                            outputString = $"You moved {directions}";
                        }
                        else
                        { 
                            outputString = "The way is shut";
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

                Console.WriteLine(outputString);
            }
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKOWN;

    }
}

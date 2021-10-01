using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Zork
{
    class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            const string RoomFileName = "Rooms.json";

            InitializeRoom(RoomFileName);

            Room Previousroom = null;

            Commands command = Commands.UNKOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom.Name}\n> ");

                if (Previousroom != CurrentRoom)
                {
                    Console.Write($"{CurrentRoom.Description}\n> ");

                    Previousroom = CurrentRoom;
                }

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;

                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = CurrentRoom.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ?$"You moved {command}." : "The way is shut";
                        break;

                    default:
                        outputString = "Unknown command";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command)
        {

            bool DidMove = true;

            switch (command)
            {
               
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;

                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;

                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    break;

                default:
                    DidMove = false;
                    break;
            }

            return DidMove;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKOWN;

        private static Room[,] Rooms;

        private static (int Row, int Column) Location = (1,1);
        private static void InitializeRoom(string RoomFileName)
        {
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(RoomFileName));
        }
    }
}

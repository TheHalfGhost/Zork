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

            const string RoomFileName = "Rooms.txt";

            InitializeRoomDescription(RoomFileName);

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

        private static readonly Room[,] Rooms =
            {
                 {new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View")},
                 {new Room("Forest"), new Room("West of House"), new Room("Behind the House")},
                 {new Room("Dense Woods"), new Room("North of House"),new Room("Clearing")}
            };

        private static (int Row, int Column) Location = (1,1);

        private enum Fields
        {
            Name = 0,
            Description
        }

        private static void InitializeRoomDescription(string RoomFileName)
        {
            var RoomMap = new Dictionary<string, Room>();

            foreach(Room room in Rooms)
            {
                RoomMap.Add(room.Name, room);
            }

            string[] lines = File.ReadAllLines(RoomFileName);

            foreach (string line in lines)
            {
                const string FieldDelimiter = "##";

                const int ExpectedFieldCount = 2;

                string[] fields = line.Split(FieldDelimiter);

                if (fields.Length != ExpectedFieldCount)
                {
                    throw new InvalidDataException("Invalid record.");
                }

                string name = fields[(int)Fields.Name];
                string description = fields[(int)Fields.Description];

                RoomMap[name].Description = description;
            }
        }
    }
}

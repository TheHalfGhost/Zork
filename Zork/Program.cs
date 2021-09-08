using System;

namespace Zork
{
    class Program
    {
        private static string Location
        {
            get
            {
                return Rooms[LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{Rooms[LocationColumn]}\n> ");

                command = ToCommand(Console.ReadLine().Trim().ToUpper());

                string outputString;

                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door. A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}." : "The way is shut!";
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
            bool DidMove = false;

            switch (command)
            {
               
                case Commands.NORTH:
                case Commands.SOUTH:
                    DidMove = false;
                    break;

                case Commands.EAST when LocationColumn < Rooms.Length - 1:
                    LocationColumn++;
                    DidMove = true;
                    break;

                case Commands.WEST when LocationColumn > 0:
                    LocationColumn--;
                    DidMove = true;
                    break;
            }
            return DidMove;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKOWN;

        private static string[] Rooms = {"Forest","West of House","Behind House","Clearing","Canyon View"};

        private static int LocationColumn = 1;
    }
}

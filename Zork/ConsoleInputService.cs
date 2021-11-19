using System;

namespace Zork
{
    internal class ConsoleInputService: IInputService
    {
       public event EventHandler<string> InputReceived;

        public void GetInput()
        {
            string inputstring = Console.ReadLine();

            if (string.IsNullOrEmpty(inputstring) == false)
            { 
                InputReceived?.Invoke(this, inputstring);
            }
        }
    }
}

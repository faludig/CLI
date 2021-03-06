using System;

namespace CommandLineInterface
{
    class BasicServices
    {
        public string help;

        public BasicServices(string help)
        {
            this.help = help;
        }

        public void ClearConsole(params object[] args)
        {
            Console.Clear();
        }

        public void Nothing(params object[] args)
        {
        }

        public void InvalidCommand(params object[] args)
        {
            Console.WriteLine("Invalid command.");
        }

        public void PrintHelp(params object[] args)
        {
            Console.WriteLine(this.help);
        }
    }
}
using System;

namespace CommandLineInterface
{
    class BasicServices
    {
        public string help;

        public BasicServices(string _help)
        {
            help = _help;
        }

        public void ClearConsole(params object[] _args)
        {
            Console.Clear();
        }

        public void Nothing(params object[] _args)
        {
        }

        public void InvalidCommand(params object[] _args)
        {
            Console.WriteLine("Invalid command.");
        }

        public void PrintHelp(params object[] _args)
        {
            Console.WriteLine(help);
        }
    }
}
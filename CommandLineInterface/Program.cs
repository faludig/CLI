using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineInterface
{
    class Program
    {
        const string APP_NAME =         "Command Line Interface";
        const string APP_VERSION =      "v0.1";
        const string APP_CONTACT =      "faludi.gabor@verebelyszki.hu";
        const string APP_DESCRIPTION =  "This application is just a basic command line interface.";

        string help = $"Description: \n\t{APP_DESCRIPTION}\n" +
                      $"Contact: \n\t{APP_CONTACT}\n" +
                       "Commands:\n" +
                       "\tclear: clear console\n" +
                       "\texit: close application\n" +
                       "\thelp: open this page\n" +
                       "\tquit: close application";
      
        void Menu(string _input, ref bool _exit)
        {
            switch (_input)
            {
                case "clear":
                    Console.Clear();
                    break;
                case "help":
                    Console.WriteLine(help);
                    break;
                case "quit":
                case "exit":
                    _exit = true;
                    break;
                case "":
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

        void UserInterface()
        {
            string promt = "> ";
            bool exit = false;

            do
            {
                Console.Write(promt);
                Menu(Console.ReadLine().ToLower(), ref exit);
            } while (!exit);
        }

        Program(string _name, string _version, string _contact)
        {
            string startup = $"{APP_NAME} {APP_VERSION}\n" +
                              "Type 'help' for more information.\n";

            Console.WriteLine(startup);
        }

        static void Main(string[] args)
        {
            Program p = new Program(APP_NAME, APP_VERSION, APP_CONTACT);
            p.UserInterface();
        }
    }
}

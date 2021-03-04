using System;
using System.Collections.Generic;

namespace CommandLineInterface
{
    class Application
    {
        public string APP_NAME;
        public string APP_VERSION;
        public string APP_CONTACT;
        public string APP_DESCRIPTION;

        public string startup;
        public string help;

        public string prompt;
        public static BasicServices services;
        public delegate void ParamsAction(params object[] _args);
        public Dictionary<string, ParamsAction> serviceMapping;
        
        public Application(string _prompt)
        {
            prompt = _prompt;
            help =    "Description: \n\t{0}\n" +
                      "Contact: \n\t{1}\n" +
                       "Commands:\n" +
                       "\tclear: clear console\n" +
                       "\texit: close application\n" +
                       "\thelp: open this page\n" +
                       "\tquit: close application\n";

            services = new BasicServices(help);
            serviceMapping = new Dictionary<string, ParamsAction>()
            {
                {"", services.Nothing },
                {"help", services.PrintHelp },
                {"clear", services.ClearConsole }
            };
        }

        public bool Menu(string _command)
        {
            switch (_command)
            {
                case "exit":
                case "quit":
                    return true;
                default:
                    try
                    {
                        serviceMapping[_command]();
                    }
                    catch (Exception)
                    {
                        services.InvalidCommand();
                    }
                    return false;
            }
        }
    }
}
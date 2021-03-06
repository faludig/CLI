using System;

namespace CommandLineInterface
{
    class Main : Application
    {
        static UserInterface test = new UserInterface(new TestApp());

        public void RunTestApp(params object[] args)
        {
            test.Run();
        }

        public Main() : base("> ")
        {
            appName =          "Command Line Interface";
            appVersion =       "v0.2";
            appContact =       "faludi.gabor@verebelyszki.hu";
            appDescription =   "This application is just a basic command line interface.";

            startup = $"{appName} {appVersion}\n" +
                       "Type 'help' for more information.\n";

            services.help = String.Format(help, appDescription, appContact) +
                            "\tapp: run test application\n";

            serviceMapping.Add("app", this.RunTestApp);
        }
    }
}
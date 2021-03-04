using System;

namespace CommandLineInterface
{
    class Main : Application
    {
        static UserInterface test = new UserInterface(new TestApp());

        public void RunTestApp(params object[] _args)
        {
            test.Run();
        }

        public Main() : base("> ")
        {
            APP_NAME =          "Command Line Interface";
            APP_VERSION =       "v0.2";
            APP_CONTACT =       "faludi.gabor@verebelyszki.hu";
            APP_DESCRIPTION =   "This application is just a basic command line interface.";

            startup = $"{APP_NAME} {APP_VERSION}\n" +
                       "Type 'help' for more information.\n";

            services.help = String.Format(help, APP_DESCRIPTION, APP_CONTACT) +
                            "\tapp: run test application\n";

            serviceMapping.Add("app", this.RunTestApp);
        }
    }
}
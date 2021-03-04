using System;

namespace CommandLineInterface
{
    class TestApp : Application
    {
        public void HelloWorld(params object[] _args)
        {
            Console.WriteLine("Hello World!");
        }

        public TestApp() : base(": ")
        {
            APP_NAME =          "Test Application";
            APP_VERSION =       "v0.1";
            APP_CONTACT =       "some.test@e.mail";
            APP_DESCRIPTION =   "This is a test application.";

            startup = $"{APP_NAME} {APP_VERSION}\n" +
                       "Type 'help' for more information.\n";

            services.help = String.Format(help, APP_DESCRIPTION, APP_CONTACT) +
                            "\thw: print 'Hello World!'\n";

            serviceMapping.Add("hw", this.HelloWorld);
        }
    }
}
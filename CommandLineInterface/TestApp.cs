using System;

namespace CommandLineInterface
{
    class TestApp : Application
    {
        public void HelloWorld(params object[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public TestApp() : base(": ")
        {
            appName =          "Test Application";
            appVersion =       "v0.1";
            appContact =       "some.test@e.mail";
            appDescription =   "This is a test application.";

            startup = $"{appName} {appVersion}\n" +
                       "Type 'help' for more information.\n";

            services.help = String.Format(help, appDescription, appContact) +
                            "\thw: print 'Hello World!'\n";

            serviceMapping.Add("hw", this.HelloWorld);
        }
    }
}
using System;

namespace CommandLineInterface
{
    class UserInterface
    {
        Application app;

        public UserInterface(Application app)
        {
            this.app = app;
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(app.startup);

            do
            {
                Console.Write(app.prompt);
            } while (!app.Menu(Console.ReadLine().ToLower()));
        }  
    }
}
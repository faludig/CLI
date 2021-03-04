using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineInterface
{
    class Program
    {
        static UserInterface main = new UserInterface(new Main());

        static void Main(string[] args)
        {
            main.Run();
        }
    }
}
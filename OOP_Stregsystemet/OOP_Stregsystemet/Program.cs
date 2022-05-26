using System;
using System.Collections.Generic;

namespace OOP_Stregsystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Stregsystem system = new Stregsystem();
            StregsystemCLI cli = new StregsystemCLI(system);

            cli.Start();
        }
    }
}

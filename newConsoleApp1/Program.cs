using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            lab3 testing = new lab3();
            testing.write();
            Console.WriteLine("Enter param:");
            string s = Console.ReadLine();
            testing.write(s);
            testing.cortage();
            Console.ReadKey();
        }
    }
}

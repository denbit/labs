using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace newConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            init();
            //Console.WriteLine("Select lab to run:");
            //string lab;
            //while ((lab = Console.ReadLine()) != "exit") {
            //    Console.WriteLine("selecting "+lab+" .....");
            //    switch (lab)
            //    {
            //        //case 

            //    }
            //}
            
            //lab3 lb3 = new lab3();
            //Console.WriteLine("Coding:");
            //lb3.Cw8();
            //Console.WriteLine("DeCoding:");
            //lb3.Cw9();
            //  (new lab6()).run();
            //(new lab7()).Cw2(@"test.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            lab9 lb = new lab9();
            if (Console.ReadLine().Equals("show"))
            {
                lb.show();

            }

        Console.ReadKey();

            /*   testing.write();
               Console.WriteLine("Enter param:");
               string s = Console.ReadLine();
               testing.write(s);
               testing.cortage();
               Console.ReadKey();*/
        }

        private static void init() {
            Console.WindowWidth = 121;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("".PadLeft(120,'*'));
            Console.WriteLine("Initiating lab main program!".PadLeft(80,'*').PadRight(120,'*'));
            Console.WriteLine("".PadLeft(120, '*'));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;          

        }
    }
}

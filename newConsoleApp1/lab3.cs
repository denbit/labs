
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace newConsoleApp1
{
    internal  class lab3
    {
        public lab3()
        {
        }
        public void Write() => Console.WriteLine("it is arrow function");
        public void write(string s) => Console.WriteLine($"it is arrow function with param {s}");
        public void Cortage()
        {
            var cort = (3, name: 4);

            write(Convert.ToString(cort.Item1));
            write(Convert.ToString(cort.name));
        }
        public void Cw1()
        {
            Console.WriteLine("Enter Symbol@!");
            char x;
            while (!Char.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect Symbol please only one symbol@!");
            }
            Console.WriteLine("Enter amount@!");
            int end;
            while (!int.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("Incorrect end please Enter amount@ again!");
            }
            for (int v = 0; v < end; v++, Console.Write(x)) ;
        }


        public void Cw2()
        {
            char[] line = Console.ReadLine().ToCharArray();

            for (int st = line.Length; st > 0; st--)
            {
                Console.Write(line[st - 1]);
            }

        }
        public void Cw3(string x) => Console.Write(x.ToUpper());

        public void Cw4()
        {
            string s, s0;
            Console.WriteLine("Please enter base string:");
            s = Console.ReadLine();
            Console.WriteLine("Please enter what to search:");
            s0 = Console.ReadLine();
            Console.WriteLine(s.Contains(s0));

        }
        public void Cw5()
        {
            string s, s0;
            Console.WriteLine("Please enter base string:");
            s = Console.ReadLine();
            Console.WriteLine("Please enter what to search&delete:");
            s0 = Console.ReadLine();
            int pos;
            if ((pos = s.LastIndexOf(s0)) != -1)
            {
                Console.WriteLine(s.Remove(pos, s0.Length));
            }
            else
            {
                Console.WriteLine(s);
            }
        }
        public void Cw6()
        {
            string s = Console.ReadLine();
            string s1="";
            Regex reg = new Regex(@"\s\w+\s");
            MatchCollection m = reg.Matches(s);
            
            

            if (m.Count > 0)
            {
                foreach(Match mm in m)
                {
                  s1=mm.Value;
                    break;
                }
            }
            else {
                s1=" ";
            }
            Console.Write($"Result is '{s1}'");
        }
        public void Cw7()
        {
            string s = Console.ReadLine();
            Regex reg = new Regex(@"\s*(\w+)\s*");
            MatchCollection m = reg.Matches(s);

            if (m.Count > 0)
            {               
                int maxsz = 0;
                foreach (Match mm in m)
                {
                    maxsz =(mm.Groups[1].Length>maxsz)? mm.Groups[1].Length:maxsz;
                }
                Console.WriteLine($"Result length is '{maxsz}'");
            }         
           

        }
        public void Cw8()
        {
            char[] s = Console.ReadLine().ToCharArray();

            for(byte i = 0, ct=0; i < s.Length;ct+=2,i++)
            {

                if (ct <= (s.Length-1))
                {
                    Console.Write(s[ct]);
                    
                }
                else
                {
                    ct = 1;
                    Console.Write(s[ct]);
                }

            }

        }
        public void Cw9()
        {
            char[] s = Console.ReadLine().ToCharArray();
            StringBuilder sb;
            for (byte i = 0, ct = 0; i < s.Length; ct += 2, i++)
            {

                if (ct <= (s.Length - 1))
                {
                    Console.Write(s[ct]);

                }
                else
                {
                    ct = 1;
                    Console.Write(s[ct]);
                }

            }

        }
    }
    
}


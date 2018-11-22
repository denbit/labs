using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace newConsoleApp1
{
    class lab7
    {   public void Cw1(string orig, string copy)
        {
            FileInfo file = new FileInfo(orig);
            if(file.Exists) {
               FileInfo cp= file.CopyTo(copy);
                if (cp.Exists)
                    Console.WriteLine("Success!");
                else
                    Console.WriteLine("Error!");

            } else
            {
                throw  new FileNotFoundException(orig+" does not exist!");
            }
        }
        public string Cw2(string orig)
        {
            FileStream fs = new FileStream(orig, FileMode.Open);
            if (fs.CanRead) {
                int i=0;
                byte[] buf=new byte[1];
                StringBuilder sb = new StringBuilder();
                while (i++ < fs.Length)
                {
                   fs.Read(buf,0,1);
                 char[] s=  Encoding.ASCII.GetChars(buf);
                    if (s[0] == 'g')
                    {
                        s[0] = '1';
                    }
                    Console.WriteLine(s[0]);
                    sb.Append(s);
                }
                Console.WriteLine(sb.ToString());
                StreamWriter tw = new StreamWriter(orig + "_copy", false);
                tw.Write(sb.ToString());
                tw.Close();
                return sb.ToString();
            }
            else { return ""; }
   
        }
        public void Cw3()
        {
            DirectoryInfo d = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            view(d);
        }
        private void view(DirectoryInfo d)
        {
            Console.WriteLine("Current dir is " + d.Name);
            Console.WriteLine("Files in " + d.Name);
            foreach (var file in d.EnumerateFiles())
            {
                Console.WriteLine(file.FullName);
            }
            if (Enumerable.Count(d.EnumerateDirectories()) > 0)
            {
                Console.WriteLine("Dirs in "+ d.Name);
                foreach(var dirs in d.GetDirectories())
                {
                    Console.WriteLine(dirs.FullName);
                }
                foreach (var dir in d.EnumerateDirectories())
                {
                    view(dir);
                }

            }
        }
    }
}

using System;
using System.Collections;
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
        public void Cw4()
        {
            DirectoryInfo d = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            StreamWriter fs = new StreamWriter("filelist.txt",true,Encoding.Unicode);
            foreach (var file in d.EnumerateFiles())
            {
                string line = file.Name + " " + file.Directory + " " + file.LastWriteTime.ToString();
                fs.WriteLine(line);
            }
            fs.Close();
        }
        public void Cw5()
        {
            StreamReader ts = new StreamReader("filelist.txt", true);
            string line;
            
            Console.WriteLine("Symbols in file " + ts.ReadToEnd().Replace("\r\n", "\r").Length);
            ts.BaseStream.Seek(0, 0);
            int count = 0;
            int sz = 0;
            while ((line = ts.ReadLine()) != null)
            {
                count++;
                Console.WriteLine($"Line #{count} contain {line.Length} symbols");
                sz += line.Length;
            }
            Console.WriteLine("Lines:"+count);
            Console.WriteLine( sz);
            ts.Close();

        }
         public void Cw6()
        {
            string[] lines=File.ReadAllLines("filelist.txt");
            ArrayList array = new ArrayList(lines);
            array.RemoveRange((lines.Length - 3), 3);
            string[] dest = (String[])array.ToArray(typeof(string));
            File.WriteAllLines("filelist1.txt", dest);

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

﻿
using System;

namespace newConsoleApp1
{
public class lab3
{
	public lab3()
	{
	}
      public  void write() => Console.WriteLine("it is arrow function");
        public void write(string s) => Console.WriteLine($"it is arrow function with param {s}");
      public void cortage()
        {
            var cort = (3,name:4);
            
            write(Convert.ToString( cort.Item1));
            write(Convert.ToString(cort.name));
        }
}
}

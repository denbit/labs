using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newConsoleApp1
{
    class lab6
    {
    }
    class Student {
        private string name;
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
            private ArrayList grade;
        public ArrayList Grade
        {
            get {
                return this.grade;
            }
            set {
                this.grade.Add(value);
            }
        }
        public int getSum() {
            int res = 0;
            foreach (int i in this.grade)
            {
                res = res + i;
            }
            return res;

        }
    }
    class Journal : Dictionary<string, newConsoleApp1.Student>
    {
        public Journal()
        {
        }

        public void AddRank(int rank, string name)
        {
            this[name].Grade.Add(rank);
        }
        public void GetAvgr(string name, out double avrg)
        {
            if (!(this.ContainsKey(name)))
            {
                throw new Exception("Student not found");
            }
            avrg = this[name].getSum() / this[name].Grade.Count;
        }

        public static string getStats(Journal j)
        {
            string str = "";
            foreach (var st in j)
            {
                //j.
            }
            return "";
        }
    }
    }



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newConsoleApp1
{
    class lab6
    {
        public void run()
        {
            Journal j = new Journal();
            j.Add("vasja", (new Student("vasja")));
            j.Add("vasja1", (new Student("vasja1")));
            j.AddRank(4, "vasja");
            j.AddRank(5, "vasja");
            j.AddRank(2, "vasja");
            j.AddRank(5, "vasja1");
            j.AddRank(5, "vasja1");
            j.AddRank(2, "vasja1");
            Journal.getStats(j);
            j.Remove("vasja");
        }
    }
    public class Student
    {
        public Student()
        {
            grade = new ArrayList();
        }
        public Student(string name) : this()
        {
            this.name = name;
        }
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private ArrayList grade;
        public ArrayList Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade.Add(value);
            }
        }
        public int getSum()
        {
            int res = 0;
            foreach (int i in this.grade)
            {
                res = res + i;
            }
            return res;

        }
        public float getAvrg()
        {
            float avrg;
            return avrg = this.getSum() / this.Grade.Count;
        }
    }

    class Journal : Dictionary<string, newConsoleApp1.Student>
    {
        public Journal()
        {
        }

        public void AddRank(int rank, string name)
        {

            if ((rank >= 1) && (rank <= 5))
                this[name].Grade.Add(rank);
        }
        public void GetAvgr(string name, out double avrg)
        {
            if (!(this.ContainsKey(name)))
            {
                throw new Exception("Student not found");
            }
            avrg = this[name].getAvrg();

        }

        public static void getStats(Journal j)
        {         
            foreach (var st in j)
            {
                Console.WriteLine(st.Key + "=>" + st.Value.getAvrg());
            }        
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Windows.Forms;
namespace newConsoleApp1
{
  
    class lab9
    {
        private Form form;
        public void show()
        {
            this.form = new Form1();
            
            Application.Run(form);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Organism
    {
        public string Name;
        public int age;

        public void sayAge()
        {
            MessageBox.Show(Name + "is " + age + " years old.");
        }
    }
}

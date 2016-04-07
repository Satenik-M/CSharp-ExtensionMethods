using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsSMB
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {

            this.Name = name;
            this.Age = age;

        }
        public override string ToString()
        {
            return this.Name + ": " + this.Age;
        }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;


            return this.Age.CompareTo(p.Age);
        }
    }
}


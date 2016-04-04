using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsSMB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6,7 };
            array.ToScreen();
            Console.WriteLine("the new array with even memebers only");
            array.EvenElements().ToScreen();
            Console.ReadLine();

        }
    }
}

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
            /*Unicoll<int> mycoll = new Unicoll<int>();


             mycoll.Add(0);
             mycoll.Add(1);

             mycoll.Add(5);
             mycoll.Add(3);
             mycoll.Add(4);
             mycoll.Add(5);
             Console.WriteLine(mycoll.ToString());
             Console.WriteLine("Count of Elements " + mycoll.Count);

             Console.WriteLine("The index of 5 is "+ mycoll.IndexOf(5));

             Console.WriteLine("removing 3");
             mycoll.Remove(5);
             Console.WriteLine(mycoll);
             Console.WriteLine("Count of Elements " + mycoll.Count);

             Console.WriteLine("removing element with index 2");

             mycoll.RemoveAt(2);
             Console.WriteLine(mycoll);
             Console.WriteLine("Count of Elements " + mycoll.Count);

             Console.WriteLine("Sorting the collection");
             mycoll.Sort();
             Console.WriteLine(mycoll);

             Console.WriteLine("Testing foreach");

             foreach (var item in mycoll)
             {
                 Console.WriteLine(item);
             }*/

            /*-----Person collection--------*/

            Unicoll<Person> myColl = new Unicoll<Person>();

            myColl.Add(new Person("Aram", 25));
            myColl.Add(new Person("Arman", 23));
            myColl.Add(new Person("Davit", 30));
            myColl.Add(new Person("Narek", 28));

            Console.WriteLine(myColl);
            myColl.Sort();
            Console.WriteLine(myColl);
            myColl.Remove(myColl[1]);
            Console.WriteLine(myColl);
            myColl.RemoveAt(0);
            Console.WriteLine(myColl);

            foreach (var item in myColl)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            /*int[] array = new int[] { 1, 2, 3, 4, 5, 6,7 };
            array.ToScreen();
            Console.WriteLine("the new array with even memebers only");
            array.EvenElements().ToScreen();
            Console.ReadLine();*/

        }
    }
}
